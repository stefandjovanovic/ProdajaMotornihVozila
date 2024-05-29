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
            popuniPodacima();
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
            ObavljeniServisBasic obavljeniServis = listaObavljenihServisa.SelectedItems[0].Tag as ObavljeniServisBasic;
            int id = obavljeniServis.Id;

            StringBuilder sb = new StringBuilder();

            try
            {
                ObavljeniServisView servis = DTOManager.vratiObavljeniServis(id);
                sb.AppendLine("Model vozila: " + servis.Model);
                sb.AppendLine("Registarski broj: " + servis.RegistarskiBroj);
                sb.AppendLine("Godina proizvodnje: " + servis.GodinaProizvodnje);
                sb.AppendLine("Datum prijema:" + servis.DatumPrijema);
                sb.AppendLine("Datum zavrsetka: " + (servis.DatumZavrsetka != null ? servis.DatumZavrsetka : "Nije zavrsen"));
                sb.AppendLine("Mesto servisa: " + servis.GradServisa + ", " + servis.AdresaServisa);
                sb.AppendLine("MBR izvrsioca prijema: " + servis.MbrIzvrsiocaPrijema);
                sb.AppendLine("Opis: " + servis.Opis);
                MessageBox.Show(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaObavljenihServisa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati servis iz liste.");
                return;
            }
            ObavljeniServisBasic obavljeniServis = listaObavljenihServisa.SelectedItems[0].Tag as ObavljeniServisBasic;
            int id = obavljeniServis.Id;

            try
            {
                DTOManager.obrisiObavljeniServis(id);
                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaObavljenihServisa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati servis iz liste.");
                return;
            }
            ObavljeniServisBasic obavljeniServis = listaObavljenihServisa.SelectedItems[0].Tag as ObavljeniServisBasic;
            int id = obavljeniServis.Id;

            DodajServisForma forma = new DodajServisForma(id);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void listaObavljenihServisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
