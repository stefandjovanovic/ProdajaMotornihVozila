using ProdajaMotornihVozila.Forme.PredstavnistvoForme;
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
    public partial class PredstavnistvaForma : Form
    {
        public PredstavnistvaForma()
        {
            InitializeComponent();
        }

        private void popuniPodatke()
        {
            listaPredstavnistva.Items.Clear();
            try
            {
                List<PredstavnistvoBasic> predstavnistva = DTOManager.vratiSvaPredstavnistva();
                foreach (PredstavnistvoBasic p in predstavnistva)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.PredstavnistvoId.ToString(), p.Grad, p.Adresa, p.ImeDirektora + " " + p.PrezimeDirektora });
                    item.Tag = p;
                    listaPredstavnistva.Items.Add(item);
                }
                listaPredstavnistva.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikoom ucitavanj podataka: " + ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPredstavnistvoForma forma = new DodajPredstavnistvoForma();
            forma.ShowDialog();
            popuniPodatke();
        }

        private void PredstavnistvaForma_Load(object sender, EventArgs e)
        {
            popuniPodatke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate selektovati predstavnistvo");
                return;
            }

            PredstavnistvoBasic p = (PredstavnistvoBasic)listaPredstavnistva.SelectedItems[0].Tag;
            int id = int.Parse(listaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            DodajPredstavnistvoForma forma = new DodajPredstavnistvoForma(p, id);
            forma.ShowDialog();
            popuniPodatke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate selektovati predstavnistvo");
                return;
            }

            int id = int.Parse(listaPredstavnistva.SelectedItems[0].SubItems[0].Text);
            try
            {
                DTOManager.obrisiPredstavnistvo(id);
                popuniPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom brisanja predstavnistva: \n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate selektovati predstavnistvo");
                return;
            }

            int id = int.Parse(listaPredstavnistva.SelectedItems[0].SubItems[0].Text);
            try
            {
                RadnjaView r = DTOManager.prikaziSadrzaj(id);
                RadnjaForma forma = new RadnjaForma(r, id);
                forma.ShowDialog();
                this.popuniPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDodajRadnju_Click(object sender, EventArgs e)
        {
            if (listaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate selektovati predstavnistvo");
                return;
            }

            int id = int.Parse(listaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            if (DTOManager.PosedujeRadnju(id))
            {
                MessageBox.Show("Predstavnistvo vec poseduje radnju");
                return;
            }

            UrediRadnjuForma forma = new UrediRadnjuForma(id);
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate selektovati predstavnistvo");
                return;
            }

            int id = int.Parse(listaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            if (DTOManager.PosedujeRadnju(id))
            {
                try
                {
                    DTOManager.ObrisiRadnjuUPredstavnistvu(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska prilikom brisanja radnje: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Predstavnistvo ne poseduje radnju");
            }
        }
    }
}
