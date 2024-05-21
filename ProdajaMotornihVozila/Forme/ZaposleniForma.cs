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
    }
}
