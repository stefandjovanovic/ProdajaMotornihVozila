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
                    TehnickeStruke zaposleni = session.Load<TehnickeStruke>("1234567890123");
                    EkonomskeStruke zaposleni2 = session.Load<EkonomskeStruke>("6024395763401");
                    zaposleni2.RukovodiocZaposlenog = zaposleni;

                    //MessageBox.Show(zaposleni.Ime + " " + zaposleni.Prezime + " " + zaposleni.Plata + " " + zaposleni.DatumZaposlenja
                    //    + " " + zaposleni.Institucija + " " + zaposleni.StrucnaSprema);

                    //TehnickeStruke zaposleni1 = new()
                    //{
                    //    MaticniBroj = "5383684257237",
                    //    Ime = "Mohamed",
                    //    Prezime = "Salah",
                    //    DatumRodjenja = new DateTime(1992, 6, 23),
                    //    DatumZaposlenja = new DateTime(2022, 12, 4),
                    //    DatumSticanjaDiplome = new DateTime(2014, 4, 5),
                    //    StrucnaSprema = "7. stepen",
                    //    NazivSpecijalnosti = "Fubaler",
                    //    Institucija = "Liverpool FC",
                    //    TipZaposlenja="Stalno",
                    //    Plata = 65345.26f
                    //};

                    await session.SaveOrUpdateAsync(zaposleni2);
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

        private async void RadnjaProba_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    OvlasceniServisISalon servisSalon = session.Load<OvlasceniServisISalon>(1);
                    MessageBox.Show(servisSalon.PripadaPredstavnistvu.Direktor.Ime);
                    foreach(var servis in  servisSalon.ServisiNizegRanga) 
                    {
                        MessageBox.Show(servis.Limarske);
                    }

                    Salon salon = new()
                    { 
                        PripadaPredstavnistvu = servisSalon.PripadaPredstavnistvu
                    };

                    await session.SaveOrUpdateAsync(salon);
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
    }
}
