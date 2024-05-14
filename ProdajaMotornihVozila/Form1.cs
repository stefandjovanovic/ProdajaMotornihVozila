using NHibernate;
using ProdajaMotornihVozila.Entiteti;

namespace ProdajaMotornihVozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UcitavanjeZaposlenog_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null) 
                {
                    Zaposleni zaposleni = session.Load<Zaposleni>("4561237890456");
                    MessageBox.Show(zaposleni.Ime + " " + zaposleni.Prezime + " " + zaposleni.Plata + " " + zaposleni.DatumZaposlenja
                        + " " + zaposleni.DatumIstekaUgovora + " " + zaposleni.StrucnaSprema);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();

            }
        }
    }
}
