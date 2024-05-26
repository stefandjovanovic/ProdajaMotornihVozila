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
            DodajServisForma forma= new DodajServisForma();
            forma.ShowDialog();
        }
    }
}
