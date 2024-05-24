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
    public partial class VozilaForma : Form
    {
        public VozilaForma()
        {
            InitializeComponent();
        }

        private void VozilaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {

        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            /*DodajVoziloForma forma = new DodajVoziloForma();
            forma.ShowDialog();
            this.popuniPodacima();*/
        }
    }
}
