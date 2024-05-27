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
    }
}
