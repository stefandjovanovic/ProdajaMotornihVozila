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
    public partial class PostaviRukovodiocaForm : Form
    {
        private string jmbgZaposlenog;

        public PostaviRukovodiocaForm(string jmbg)
        {
            this.jmbgZaposlenog = jmbg;
        }

        private void PostaviRukovodiocaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pozovi funkciju
            string jmbgRukovodioca = textBox1.Text;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
