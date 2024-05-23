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

            List<ZaposleniBasic> zaposleni = DTOManager.vratiSveZaposlene();

            foreach (ZaposleniBasic z in zaposleni)
            {
                ListViewItem item = new ListViewItem(new string[] { z.ZaposleniId, z.Ime, z.Prezime, z.StrucnaSprema, z.TipZaposlenja, z.TipStruke });
                item.Tag = z;
                listaZaposlenih.Items.Add(item);
            }

            listaZaposlenih.Refresh();

        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {

        }
    }
}
