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
    public partial class PostaviRukovodiocaForm : Form
    {
        private string jmbgZaposlenog;

        public PostaviRukovodiocaForm(string jmbg)
        {
            this.jmbgZaposlenog = jmbg;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Morate uneti JMBG zaposlenog");
                return;
            }
            if(textBox1.Text.Length != 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara");
                return;
            }

            string jmbgRukovodioca = textBox1.Text;

            try
            {
                DTOManager.postaviRukovodioca(jmbgRukovodioca, jmbgZaposlenog);
                MessageBox.Show("Uspesno postavljen rukovodilac");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }
    }
}
