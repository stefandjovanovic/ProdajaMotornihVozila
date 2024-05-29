using ProdajaMotornihVozila.Forme.ProdajaForme;
using ProdajaMotornihVozila.Forme.VozilaForme;
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
    public partial class ProdajaForma : Form
    {
        public ProdajaForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajProdajuForma forma = new DodajProdajuForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void ProdajaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();

            List<ProdajaBasic> prodajaBasics = DTOManager.VratiSveProdaje();

            foreach (ProdajaBasic p in prodajaBasics)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.MBRProdavca, p.BrojSasije, p.IdMestaProdaje.ToString(), p.IdKupca.ToString() });
                item.Tag = p;
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali prodaju!");
                return;
            }


            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu prodaju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                try
                {
                    DTOManager.ObrisiProdaju(id);
                    MessageBox.Show("Brisanje prodaje je uspesno obavljeno!");
                    this.popuniPodacima();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska prilikom brisanja prodaje: " + ex.Message);
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati prodaju iz liste.");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);


            StringBuilder sb = new StringBuilder();

            try
            {
                ProdajaView prodajaView = DTOManager.VratiProdaju(id);

                sb.AppendLine("ID: " + prodajaView.Id);
                sb.AppendLine("MBR prodavca: " + prodajaView.MBRProdavca);
                sb.AppendLine("Broj sasije: " + prodajaView.BrojSasije);
                sb.AppendLine("ID mesta prodaje: " + prodajaView.IdMestaProdaje);
                sb.AppendLine("ID kupca: " + prodajaView.IdKupca);
                sb.AppendLine("Tip kupca: " + prodajaView.TipKupca);
                sb.AppendLine("Ime kupca: " + prodajaView.ImeKupca);
                sb.AppendLine("Prezime kupca: " + prodajaView.PrezimeKupca);
                sb.AppendLine("Broj telefona kupca: " + prodajaView.BrojTelefona);
                sb.AppendLine("Adresa salona: " + prodajaView.AdresaSalona);
                sb.AppendLine("Grad salona: " + prodajaView.GradSalona);
                sb.AppendLine("Ime prodavca: " + prodajaView.ImeProdavca);
                sb.AppendLine("Prezime prodavca: " + prodajaView.PrezimeProdavca);
                sb.AppendLine("Model vozila: " + prodajaView.ModelVozila);

                MessageBox.Show(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom prikaza prodaje: " + ex.Message);
            }




        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali prodaju!");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            int idKupca = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);

            DodajProdajuForma forma = new DodajProdajuForma(id, idKupca);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
