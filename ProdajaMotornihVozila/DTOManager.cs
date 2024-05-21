using NHibernate;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila
{
    public class DTOManager
    {
        #region Zaposleni
        public static List<ZaposleniBasic> vratiSveZaposlene()
        {
            List<ZaposleniBasic> zaposleni = new List<ZaposleniBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> zaposleniIzBaze = from z in s.Query<Zaposleni>()
                                                         select z;

                string tip;
                foreach (Zaposleni z in zaposleniIzBaze)
                {

                    if (z.GetType() == typeof(TehnickeStruke))
                        tip = "TehnickeStruke";
                    else if (z.GetType() == typeof(EkonomskeStruke))
                        tip = "EkonomskeStruke";
                    else
                        tip = "Zaposleni";
                    zaposleni.Add(new ZaposleniBasic(z.MaticniBroj, z.Ime, z.Prezime, z.StrucnaSprema, z.TipZaposlenja, tip));
                }

                s.Close();
            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno vracanje zaposlenih! " + e.Message);
            }

            return zaposleni;
        }

        public static void obrisiZaposlenog(string zaposleniId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zaposleni = s.Load<Zaposleni>(zaposleniId);

                s.Delete(zaposleni);
                s.Flush();

                s.Close();

            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno brisanje zaposlenog! " + ex.Message);
            }

        }

        public static ZaposleniView vratiZaposlenog(int id)
        {
            ZaposleniView zaposleniView = new ZaposleniView();
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zaposleni = s.Load<Zaposleni>(id);

                string tip;

                if (zaposleni.GetType() == typeof(TehnickeStruke))
                    tip = "TehnickeStruke";
                else if (zaposleni.GetType() == typeof(EkonomskeStruke))
                    tip = "EkonomskeStruke";
                else
                    tip = "Zaposleni";
                zaposleniView = new ZaposleniView(zaposleni.MaticniBroj, zaposleni.Ime, zaposleni.Prezime, zaposleni.StrucnaSprema, zaposleni.TipZaposlenja, tip, zaposleni.DatumRodjenja, zaposleni.DatumZaposlenja, zaposleni.Plata, zaposleni.DatumIstekaUgovora);

                s.Close();
            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno vracanje zaposlenog! " + e.Message);
            }

            return zaposleniView;
        }


        public static void dodajZaposlenog(ZaposleniView zaposleniView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni o = new()
                {
                    MaticniBroj = zaposleniView.ZaposleniId,
                    Ime = zaposleniView.Ime,
                    Prezime = zaposleniView.Prezime,
                    DatumRodjenja = zaposleniView.DatumRodjenja,
                    DatumZaposlenja = zaposleniView.DatumZaposlenja,
                    StrucnaSprema = zaposleniView.StrucnaSprema,
                    TipZaposlenja = zaposleniView.TipZaposlenja,
                    Plata = zaposleniView.Plata,
                    DatumIstekaUgovora = zaposleniView.DatumIstekaUgovora

                };

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();

            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno dodavanje zaposlenog! " + e.Message);
            }
        }

        public static void azurirajZaposlenog(ZaposleniView zaposleniView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zaposleni = s.Load<Zaposleni>(zaposleniView.ZaposleniId);

                zaposleni.Ime = zaposleniView.Ime;
                zaposleni.Prezime = zaposleniView.Prezime;
                zaposleni.DatumRodjenja = zaposleniView.DatumRodjenja;
                zaposleni.DatumZaposlenja = zaposleniView.DatumZaposlenja;
                zaposleni.StrucnaSprema = zaposleniView.StrucnaSprema;
                zaposleni.TipZaposlenja = zaposleniView.TipZaposlenja;
                zaposleni.Plata = zaposleniView.Plata;
                zaposleni.DatumIstekaUgovora = zaposleniView.DatumIstekaUgovora;

                s.SaveOrUpdate(zaposleni);

                s.Flush();

                s.Close();
            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno azuriranje zaposlenog! " + e.Message);
            }
        }

        public static ZaposleniBasic prikaziRukovodioca(int id)
        {
            ZaposleniBasic zaposleniBasic = new ZaposleniBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zaposleni = s.Load<Zaposleni>(id);

                Zaposleni rukovodilac = zaposleni.RukovodiocZaposlenog;

                if(rukovodilac == null)
                {
                    return null;
                }

                string tip;

                if (zaposleni.GetType() == typeof(TehnickeStruke))
                    tip = "TehnickeStruke";
                else if (zaposleni.GetType() == typeof(EkonomskeStruke))
                    tip = "EkonomskeStruke";
                else
                    tip = "Zaposleni";

                zaposleniBasic.ZaposleniId = rukovodilac.MaticniBroj;
                zaposleniBasic.Ime = rukovodilac.Ime;
                zaposleniBasic.Prezime = rukovodilac.Prezime;
                zaposleniBasic.StrucnaSprema = rukovodilac.StrucnaSprema;
                zaposleniBasic.TipZaposlenja = rukovodilac.TipZaposlenja;
                zaposleniBasic.TipStruke = tip;

            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno vracanje rukovodioca! " + e.Message);
            }

            return zaposleniBasic;
        }

        public static List<ZaposleniBasic> prikaziPodredjene(int id)
        {
            List<ZaposleniBasic> zaposleni = new List<ZaposleniBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zaposleniRukovodilac = s.Load<Zaposleni>(id);

                if (zaposleniRukovodilac.PodredjeniZaposleni == null || zaposleniRukovodilac.PodredjeniZaposleni.Count == 0)
                    return null;

                foreach (Zaposleni z in zaposleniRukovodilac.PodredjeniZaposleni)
                {
                    if (z == null)
                        continue;

                    string tip;

                    if (z.GetType() == typeof(TehnickeStruke))
                        tip = "TehnickeStruke";
                    else if (z.GetType() == typeof(EkonomskeStruke))
                        tip = "EkonomskeStruke";
                    else
                        tip = "Zaposleni";

                    zaposleni.Add(new ZaposleniBasic(z.MaticniBroj, z.Ime, z.Prezime, z.StrucnaSprema, z.TipZaposlenja, tip));

                    
                }

                s.Close();
            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno vracanje podredjenih! " + e.Message);
            }

            return zaposleni;
        }

        public static void postaviRukovodioca(int idRukovodioca, int idPodredjenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni rukovodilac = s.Load<Zaposleni>(idRukovodioca);
                Zaposleni podredjeni = s.Load<Zaposleni>(idPodredjenog);

                podredjeni.RukovodiocZaposlenog = rukovodilac;
                rukovodilac.PodredjeniZaposleni.Add(podredjeni);

                s.SaveOrUpdate(podredjeni);
                s.SaveOrUpdate(rukovodilac);

                s.Flush();

                s.Close();
            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno postavljanje rukovodioca! " + e.Message);
            }
        }



        #endregion

        #region EkonomskeStruke
        public static void obrisiEkonomskeStruke(string zaposleniId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EkonomskeStruke ekonomskeStruke = s.Load<EkonomskeStruke>(zaposleniId);

                s.Delete(ekonomskeStruke);
                s.Flush();

                s.Close();

            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno brisanje zaposlenog ekonomske struke! " + ex.Message);
            }

        }

        public static EkonomStrBasic vratiZaposlenogEkonom(int id)
        {
            EkonomStrBasic ekonomStrBasic = new EkonomStrBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                EkonomskeStruke ekonomskeStruke = s.Load<EkonomskeStruke>(id);

                ekonomStrBasic.ZaposleniId = ekonomskeStruke.MaticniBroj;
                ekonomStrBasic.Ime = ekonomskeStruke.Ime;
                ekonomStrBasic.TipZaposlenja = ekonomskeStruke.TipZaposlenja;
                ekonomStrBasic.StrucnaSprema = ekonomskeStruke.StrucnaSprema;
                ekonomStrBasic.PosedujeSertifikat = ekonomskeStruke.PosedujeSertifikat;
                ekonomStrBasic.DatumSticanja = ekonomskeStruke.DatumSticanja;
                ekonomskeStruke.DatumRodjenja = ekonomskeStruke.DatumRodjenja;
                ekonomskeStruke.DatumZaposlenja = ekonomskeStruke.DatumZaposlenja;
                ekonomskeStruke.Plata = ekonomskeStruke.Plata;
                ekonomskeStruke.DatumIstekaUgovora = ekonomskeStruke.DatumIstekaUgovora;

            }
            catch (Exception e)
            {
                throw new Exception("Neuspesno vracanje zaposlenih ekonomskih struka! " + e.Message);
            }
            return ekonomStrBasic;
        }

        public static void dodajEkonomskeStruke(EkonomStrBasic ekonomStrBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EkonomskeStruke o = new()
                {
                    MaticniBroj = ekonomStrBasic.ZaposleniId,
                    Ime = ekonomStrBasic.Ime,
                    Prezime = ekonomStrBasic.Prezime,
                    TipZaposlenja = ekonomStrBasic.TipZaposlenja,
                    StrucnaSprema = ekonomStrBasic.StrucnaSprema,
                    PosedujeSertifikat = ekonomStrBasic.PosedujeSertifikat,
                    DatumSticanja = ekonomStrBasic.DatumSticanja,
                    DatumRodjenja = ekonomStrBasic.DatumRodjenja,
                    DatumZaposlenja = ekonomStrBasic.DatumZaposlenja,
                    Plata = ekonomStrBasic.Plata,
                    DatumIstekaUgovora = ekonomStrBasic.DatumIstekaUgovora

                };

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();

            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno dodavanje zaposlenog ekonomske struke! " + e.Message);
            }
        }

        public static void azurirajEkonomskeStruke(EkonomStrBasic ekonomstrBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                EkonomskeStruke ekonomskeStruke = s.Load<EkonomskeStruke>(ekonomstrBasic.ZaposleniId);

                ekonomskeStruke.Ime = ekonomstrBasic.Ime;
                ekonomskeStruke.Prezime = ekonomstrBasic.Prezime;
                ekonomskeStruke.TipZaposlenja = ekonomstrBasic.TipZaposlenja;
                ekonomskeStruke.StrucnaSprema = ekonomstrBasic.StrucnaSprema;
                ekonomskeStruke.PosedujeSertifikat = ekonomstrBasic.PosedujeSertifikat;
                ekonomskeStruke.DatumSticanja = ekonomstrBasic.DatumSticanja;
                ekonomskeStruke.DatumRodjenja = ekonomstrBasic.DatumRodjenja;
                ekonomskeStruke.DatumZaposlenja = ekonomstrBasic.DatumZaposlenja;
                ekonomskeStruke.Plata = ekonomstrBasic.Plata;
                ekonomskeStruke.DatumIstekaUgovora = ekonomstrBasic.DatumIstekaUgovora;

                s.SaveOrUpdate(ekonomskeStruke);

                s.Flush();

                s.Close();

            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno azuriranje zaposlenog ekonomske struke! " + e.Message);
            }
        }

        #endregion


        #region TehnickeStruke

        public static void obrisiTehnickeStruke(string zaposleniId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickeStruke tehnickeStruke = s.Load<TehnickeStruke>(zaposleniId);

                s.Delete(tehnickeStruke);
                s.Flush();

                s.Close();

            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno brisanje zaposlenog tehnicke struke! " + ex.Message);
            }

        }

        public static TehnickeStrBasic vratiZaposlenogTehnicke(int id)
        {
            TehnickeStrBasic tehnickeStr = new TehnickeStrBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickeStruke tehnickeStruke = s.Load<TehnickeStruke>(id);

                tehnickeStr.ZaposleniId = tehnickeStruke.MaticniBroj;
                tehnickeStr.Ime = tehnickeStruke.Ime;
                tehnickeStr.TipZaposlenja = tehnickeStruke.TipZaposlenja;
                tehnickeStr.StrucnaSprema = tehnickeStruke.StrucnaSprema;
                tehnickeStr.NazivSpecijalnosti = tehnickeStruke.NazivSpecijalnosti;
                tehnickeStr.Institucija = tehnickeStruke.Institucija;
                tehnickeStr.DatumRodjenja = tehnickeStruke.DatumRodjenja;
                tehnickeStr.DatumZaposlenja = tehnickeStruke.DatumZaposlenja;
                tehnickeStr.Plata = tehnickeStruke.Plata;
                tehnickeStr.DatumIstekaUgovora = tehnickeStruke.DatumIstekaUgovora;

            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno vracanje zaposlenih tehnickih struka! " + ex.Message);
            }

            return tehnickeStr;

            #endregion

        }

        public static void dodajTehnickeStruke(TehnickeStrBasic tehnickeStrBasic)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TehnickeStruke tehnickeStruke = new()
                {
                    MaticniBroj = tehnickeStrBasic.ZaposleniId,
                    Ime = tehnickeStrBasic.Ime,
                    Prezime = tehnickeStrBasic.Prezime,
                    TipZaposlenja = tehnickeStrBasic.TipZaposlenja,
                    StrucnaSprema = tehnickeStrBasic.StrucnaSprema,
                    NazivSpecijalnosti = tehnickeStrBasic.NazivSpecijalnosti,
                    Institucija = tehnickeStrBasic.Institucija,
                    DatumRodjenja = tehnickeStrBasic.DatumRodjenja,
                    DatumZaposlenja = tehnickeStrBasic.DatumZaposlenja,
                    Plata = tehnickeStrBasic.Plata,
                    DatumIstekaUgovora = tehnickeStrBasic.DatumIstekaUgovora,
                    DatumSticanjaDiplome = tehnickeStrBasic.DatumSticanjaDiplome

                };

                session.SaveOrUpdate(tehnickeStruke);

                session.Flush();

                session.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno dodavanje zaposlenog tehnicke struke! " + ex.Message);
            }
        }

        public static void azurirajTehnickeStuke (TehnickeStrBasic tehnickeStrBasic)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TehnickeStruke tehnickeStruke = session.Load<TehnickeStruke>(tehnickeStrBasic.ZaposleniId);

                tehnickeStruke.Ime = tehnickeStrBasic.Ime;
                tehnickeStruke.Prezime = tehnickeStrBasic.Prezime;
                tehnickeStruke.TipZaposlenja = tehnickeStrBasic.TipZaposlenja;
                tehnickeStruke.StrucnaSprema = tehnickeStrBasic.StrucnaSprema;
                tehnickeStruke.NazivSpecijalnosti = tehnickeStrBasic.NazivSpecijalnosti;
                tehnickeStruke.Institucija = tehnickeStrBasic.Institucija;
                tehnickeStruke.DatumRodjenja = tehnickeStrBasic.DatumRodjenja;
                tehnickeStruke.DatumZaposlenja = tehnickeStrBasic.DatumZaposlenja;
                tehnickeStruke.Plata = tehnickeStrBasic.Plata;
                tehnickeStruke.DatumIstekaUgovora = tehnickeStrBasic.DatumIstekaUgovora;
                tehnickeStruke.DatumSticanjaDiplome = tehnickeStrBasic.DatumSticanjaDiplome;

                session.SaveOrUpdate(tehnickeStruke);

                session.Flush();

                session.Close();
                
            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno azuriranje zaposlenog tehnicke struke! " + ex.Message);
            }
        }


    }
}

