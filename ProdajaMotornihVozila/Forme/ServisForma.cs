using ProdajaMotornihVozila.Forme.ServisForme;
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
    public partial class ServisForma : Form
    {
        public ServisForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajServisForma forma = new DodajServisForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void ServisForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listaObavljenihServisa.Items.Clear();
            List<ObavljeniServisBasic> obavljeniServisi = DTOManager.vratiObavljeneServise();

            foreach (ObavljeniServisBasic os in obavljeniServisi)
            {
                ListViewItem item = new ListViewItem(new string[] { os.Model, os.RegistarskiBroj, os.MbrIzvrsiocaPrijema, os.Opis });
                item.Tag = os;
                listaObavljenihServisa.Items.Add(item);
            }
            listaObavljenihServisa.Refresh();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (listaObavljenihServisa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati servis iz liste.");
                return;
            }


            StringBuilder sb = new StringBuilder();

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}
