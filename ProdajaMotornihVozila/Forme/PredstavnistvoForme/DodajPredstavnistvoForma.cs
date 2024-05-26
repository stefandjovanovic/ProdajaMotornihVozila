using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme.PredstavnistvoForme
{
    public partial class DodajPredstavnistvoForma : Form
    {
        private PredstavnistvoBasic? predstavnistvo;
        private int idPredstavnistva;
        private bool rezimIzmene;
        public DodajPredstavnistvoForma()
        {
            this.rezimIzmene = false;

            InitializeComponent();
        }
        public DodajPredstavnistvoForma(PredstavnistvoBasic predstavnistvo, int idPredstavnistva)
        {
            this.predstavnistvo = predstavnistvo;
            this.idPredstavnistva = idPredstavnistva;
            this.rezimIzmene = true;
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string grad = textBoxGrad.Text;
            string adresa = textBoxAdresa.Text;
            string jmbg = textBoxJMBG.Text;


            PredstavnistvoView predstavnistvo = new PredstavnistvoView(grad, adresa, jmbg);

            try
            {

                if (rezimIzmene)
                {
                    DTOManager.azurirajPredstavnistvo(idPredstavnistva, predstavnistvo);
                    this.Close();
                }
                else
                {
                    DTOManager.dodajPredstavnistvo(predstavnistvo);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom dodavanja predstavnistva:\n " + ex.Message);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPredstavnistvoForma_Load(object sender, EventArgs e)
        {
            if(this.rezimIzmene)
            {
                textBoxAdresa.Text = predstavnistvo!.Adresa;
                textBoxGrad.Text = predstavnistvo.Grad;
                textBoxJMBG.Text = predstavnistvo.JmbgDirektora;
                btnDodaj.Text = "Izmeni";
            }
        }
    }
}
