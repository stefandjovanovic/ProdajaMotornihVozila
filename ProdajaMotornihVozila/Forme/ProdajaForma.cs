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
        }

        private void ProdajaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();

            // List<ProdajaBasic> prodajaBasics = DTOManager.vratiSveProdaje();

            foreach (ProdajaBasic p in prodajaBasics)
            {
                ListViewItem item = new ListViewItem(new string[] { p.BrojProdaje, p.DatumProdaje.ToString(), p.Kupac, p.Vozilo, p.Cena.ToString() });
                item.Tag = p;
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}
