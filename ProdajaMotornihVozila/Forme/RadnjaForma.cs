using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme
{
    public partial class RadnjaForma : Form
    {
        private RadnjaView radnja;

        public RadnjaForma(RadnjaView radnja)
        {
            this.radnja = radnja;
            InitializeComponent();
        }

        private void RadnjaForma_Load(object sender, EventArgs e)
        {
            if (radnja.ImeSefa == null)
            {
                labelSef.Text = "Sef radnje: Ne postoji sef";
            }
            else
            {
                labelSef.Text = "Sef radnje: " + radnja.ImeSefa + " " + radnja.PrezimeSefa;
            }

            labelSalon.Text = "Poseduje salon: " + radnja.SalonF;
            labelServis.Text = "Poseduje servis: " + radnja.ServisF;

            if (radnja.ServisF == "Ne")
            {
                btnPrikaziServis.Enabled = false;
            }

        }

        private void btnPrikaziZaposlene_Click(object sender, EventArgs e)
        {
            try
            {
                List<ZaposleniBasic> zaposleni = DTOManager.prikaziZaposleneURadnji(radnja.Id);
                StringBuilder sb = new StringBuilder();
                foreach (ZaposleniBasic z in zaposleni)
                {
                    sb.Append(z.Ime + " " + z.Prezime + "\n");
                }
                MessageBox.Show(sb.ToString());
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrikaziServis_Click(object sender, EventArgs e)
        {
            ServisDetaljiForm servisDetalji = new ServisDetaljiForm(radnja.Id);
            servisDetalji.ShowDialog();
        }
    }
}
