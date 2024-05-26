using NHibernate;
using ProdajaMotornihVozila.Entiteti;
using ProdajaMotornihVozila.Forme;

namespace ProdajaMotornihVozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniForma forma = new ZaposleniForma();
            forma.ShowDialog();
        }

        private void btnPredstavnistva_Click(object sender, EventArgs e)
        {
            PredstavnistvaForma forma = new PredstavnistvaForma();
            forma.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            VozilaForma forma = new VozilaForma();
            forma.ShowDialog();
        }

        private void btnServisi_Click(object sender, EventArgs e)
        {
            ServisForma forma = new ServisForma();
            forma.ShowDialog();
        }

        private void btnProdaje_Click(object sender, EventArgs e)
        {
            ProdajaForma forma = new ProdajaForma();
            forma.ShowDialog();
        }

        
    }
}
