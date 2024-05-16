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

        private async void UcitavanjeZaposlenog_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    TehnickeStrukeStalno zaposleni = session.Load<TehnickeStrukeStalno>("1234567890123");
                    MessageBox.Show(zaposleni.Ime + " " + zaposleni.Prezime + " " + zaposleni.Plata + " " + zaposleni.DatumZaposlenja
                        + " " + zaposleni.Institucija + " " + zaposleni.StrucnaSprema);

                    TehnickeStrukeStalno zaposleni1 = new()
                    {
                        MaticniBroj = "5383680357237",
                        Ime = "Mohamed",
                        Prezime = "Salah",
                        DatumRodjenja = new DateTime(1992, 6, 23),
                        DatumZaposlenja = new DateTime(2022, 12, 4),
                        DatumSticanjaDiplome = new DateTime(2014, 4, 5),
                        StrucnaSprema = "7. stepen",
                        NazivSpecijalnosti = "Fubaler",
                        Institucija = "Liverpool FC"
                    };

                    await session.SaveOrUpdateAsync(zaposleni1);
                    await session.FlushAsync();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();

            }
        }

        private void RadnjaProba_Click(object sender, EventArgs e)
        {

        }
    }
}
