using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme.ZaposleniForme
{
    public partial class IzmeniZaposlenogForma : Form
    {
        private string jmbgZaposlenog;
        private string tipStruke;

        public IzmeniZaposlenogForma()
        {
            InitializeComponent();
        }

        public IzmeniZaposlenogForma(string jmbgZaposlenog, string tipStruke)
        {
            InitializeComponent();
            this.jmbgZaposlenog = jmbgZaposlenog;
            this.tipStruke = tipStruke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tipStruke == "TehnickeStruke")
            {

            }
            else if (tipStruke == "EkonomskeStruke")
            {

            }
            else
            {

            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
