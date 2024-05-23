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
    public partial class ZaposleniForma : Form
    {
        public ZaposleniForma()
        {
            InitializeComponent();
        }

        private void ZaposleniForma_Load(object sender, EventArgs e)
        {
            popuniPodatke();
        }

        private void popuniPodatke()
        {
            listaZaposlenih.Items.Clear();

        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if(listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate selektovati zaposlenog");
                return;
            }

            string jmbg = listaZaposlenih.SelectedItems[0].SubItems[0].Text;
            string tipZaposlenog = listaZaposlenih.SelectedItems[0].SubItems[4].Text;

            MessageBox.Show("Detalji zaposlenog: " + jmbg + " " + tipZaposlenog);

        }
    }
}
