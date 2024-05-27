using NHibernate;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public static ZaposleniView vratiZaposlenog(string id)
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

        public static ZaposleniBasic prikaziRukovodioca(string id)
        {
            ZaposleniBasic zaposleniBasic = new ZaposleniBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zaposleni = s.Load<Zaposleni>(id);

                Zaposleni rukovodilac = zaposleni.RukovodiocZaposlenog;

                if (rukovodilac == null)
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

        public static List<ZaposleniBasic> prikaziPodredjene(string id)
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

        public static void postaviRukovodioca(string idRukovodioca, string idPodredjenog)
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

        public static EkonomStrBasic vratiZaposlenogEkonom(string id)
        {
            EkonomStrBasic ekonomStrBasic = new EkonomStrBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                EkonomskeStruke ekonomskeStruke = s.Load<EkonomskeStruke>(id);

                ekonomStrBasic.ZaposleniId = ekonomskeStruke.MaticniBroj;
                ekonomStrBasic.Ime = ekonomskeStruke.Ime;
                ekonomStrBasic.Prezime = ekonomskeStruke.Prezime;
                ekonomStrBasic.TipZaposlenja = ekonomskeStruke.TipZaposlenja;
                ekonomStrBasic.StrucnaSprema = ekonomskeStruke.StrucnaSprema;
                ekonomStrBasic.PosedujeSertifikat = ekonomskeStruke.PosedujeSertifikat;
                ekonomStrBasic.DatumSticanja = ekonomskeStruke.DatumSticanja;
                ekonomStrBasic.DatumRodjenja = ekonomskeStruke.DatumRodjenja;
                ekonomStrBasic.DatumZaposlenja = ekonomskeStruke.DatumZaposlenja;
                ekonomStrBasic.Plata = ekonomskeStruke.Plata;
                ekonomStrBasic.DatumIstekaUgovora = ekonomskeStruke.DatumIstekaUgovora;

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

        public static TehnickeStrBasic vratiZaposlenogTehnicke(string id)
        {
            TehnickeStrBasic tehnickeStr = new TehnickeStrBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickeStruke tehnickeStruke = s.Load<TehnickeStruke>(id);

                tehnickeStr.ZaposleniId = tehnickeStruke.MaticniBroj;
                tehnickeStr.Ime = tehnickeStruke.Ime;
                tehnickeStr.Prezime = tehnickeStruke.Prezime;
                tehnickeStr.TipZaposlenja = tehnickeStruke.TipZaposlenja;
                tehnickeStr.StrucnaSprema = tehnickeStruke.StrucnaSprema;
                tehnickeStr.NazivSpecijalnosti = tehnickeStruke.NazivSpecijalnosti;
                tehnickeStr.Institucija = tehnickeStruke.Institucija;
                tehnickeStr.DatumRodjenja = tehnickeStruke.DatumRodjenja;
                tehnickeStr.DatumZaposlenja = tehnickeStruke.DatumZaposlenja;
                tehnickeStr.Plata = tehnickeStruke.Plata;
                tehnickeStr.DatumIstekaUgovora = tehnickeStruke.DatumIstekaUgovora;
                tehnickeStr.DatumSticanjaDiplome = tehnickeStruke.DatumSticanjaDiplome;

            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno vracanje zaposlenih tehnickih struka! " + ex.Message);
            }

            return tehnickeStr;



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

        public static void azurirajTehnickeStuke(TehnickeStrBasic tehnickeStrBasic)
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

        #endregion

        #region Predstavnistvo
        public static List<PredstavnistvoBasic> vratiSvaPredstavnistva()
        {
            List<PredstavnistvoBasic> values = new List<PredstavnistvoBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predstavnistvo> predstavnistva = from p in s.Query<Predstavnistvo>()
                                                             select p;

                foreach (Predstavnistvo p in predstavnistva)
                {
                    values.Add(new PredstavnistvoBasic(p.Id, p.Grad, p.Adresa, p.Direktor.Ime, p.Direktor.Prezime, p.Direktor.MaticniBroj));
                }

                s.Close();
            }

            catch (Exception e)
            {
                throw new Exception("Neuspesno vracanje predstavnistava! " + e.Message);
            }

            return values;


        }

        public static void obrisiPredstavnistvo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo predstavnistvo = s.Load<Predstavnistvo>(id);

                s.Delete(predstavnistvo);
                s.Flush();

                s.Close();

            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno brisanje predstavnistva! " + ex.Message);
            }
        }

        public static void dodajPredstavnistvo(PredstavnistvoView predstavnistvoView)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Predstavnistvo p = new()
                {
                    Adresa = predstavnistvoView.Adresa,
                    Grad = predstavnistvoView.Grad,
                    Direktor = session.Load<Zaposleni>(predstavnistvoView.IdDirektora)
                };
                session.SaveOrUpdate(p);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno dodavanje predstavnistva! " + ex.Message);
            }

        }

        public static void azurirajPredstavnistvo(int idPredstavnistva, PredstavnistvoView predstavnistvoView)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Predstavnistvo p = session.Load<Predstavnistvo>(idPredstavnistva);

                p.Adresa = predstavnistvoView.Adresa;
                p.Grad = predstavnistvoView.Grad;
                p.Direktor = session.Load<Zaposleni>(predstavnistvoView.IdDirektora);

                session.SaveOrUpdate(p);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno azuriranje predstavnistva! " + ex.Message);
            }

        }
        #endregion

        #region Radnja

        public static RadnjaView prikaziSadrzaj(int idPredstavnistva)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Radnja radnja = session.Query<Radnja>().FirstOrDefault(r => r.PripadaPredstavnistvu.Id == idPredstavnistva);

                if (radnja != null)
                {
                    return new RadnjaView
                    {
                        Id = radnja.Id,
                        ImeSefa = radnja.SefRadnje != null ? radnja.SefRadnje.Ime : null,
                        PrezimeSefa = radnja.SefRadnje != null ? radnja.SefRadnje.Prezime : null,
                        JmbgSefa = radnja.SefRadnje != null ? radnja.SefRadnje.MaticniBroj : null,
                        SalonF = radnja.GetType() == typeof(Salon) || radnja.GetType() == typeof(OvlasceniServisISalon) ? "Da" : "Ne",
                        ServisF = radnja.GetType() == typeof(OvlasceniServis) || radnja.GetType() == typeof(OvlasceniServisISalon) ? "Da" : "Ne"
                    };

                }
                else
                {
                    throw new Exception("Ne postoji radnja u predstavnistvu!");
                }


            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno vracanje sadrzaja radnje! " + ex.Message);
            }
        }

        public static List<ZaposleniBasic> prikaziZaposleneURadnji (int idRadnje)
        {
            List<ZaposleniBasic> zaposleni = new List<ZaposleniBasic>();
            try
            {
                ISession session = DataLayer.GetSession();

                Radnja radnja = session.Load<Radnja>(idRadnje);

                foreach (Zaposleni z in radnja.ZaposleniURadnji)
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
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno vracanje zaposlenih radnje! " + ex.Message);
            }

            return zaposleni;
        }

        public static ServisView detaljiServis(int idRadnje)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Radnja radnja = session.Load<Radnja>(idRadnje);

                Type actualType = NHibernateUtil.GetClass(radnja);

                if ( actualType == typeof(OvlasceniServis))
                {
                    OvlasceniServis s = session.Load<OvlasceniServis>(idRadnje);
                    ServisView sv = new()
                    {
                        Id = s.Id,
                        StepenOpremljenosti = s.StepenOpremljenosti,
                        Farbarske = s.Farbarske,
                        Limarske = s.Limarske,
                        Vulkanizerske = s.Vulkanizerske,
                        Mehanicarske = s.Mehanicarske
                    };
                    return sv;

                }
                else if (actualType == typeof(OvlasceniServisISalon))
                {
                    OvlasceniServisISalon s = session.Load<OvlasceniServisISalon>(idRadnje);
                    ServisView sv = new()
                    {
                        Id = s.Id,
                        StepenOpremljenosti = s.StepenOpremljenosti,
                        Farbarske = s.Farbarske,
                        Limarske = s.Limarske,
                        Vulkanizerske = s.Vulkanizerske,
                        Mehanicarske = s.Mehanicarske
                    };
                    return sv;
                }
                else
                {
                    throw new Exception("Radnja nije servis!");
                }


            }

            catch(Exception ex)
            {
                throw new Exception("Neuspesno vracanje detalja servisa! " + ex.Message);
            }

            
        }

        public static ServisVisegNizegRangaView servisVisegRanga (int idRadnje)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Radnja radnja = session.Load<Radnja>(idRadnje);
                Type actualType = NHibernateUtil.GetClass(radnja);


                if (actualType == typeof(OvlasceniServis))
                {
                    OvlasceniServis s = session.Load<OvlasceniServis>(idRadnje);
                    if (s.ServisVisegRanga == null)
                    {
                        throw new Exception("Salon nema servis viseg ranga!");
                    }
                    ServisVisegNizegRangaView sv = new()
                    {
                        Id = s.ServisVisegRanga.Id,
                        Adresa = s.ServisVisegRanga.PripadaPredstavnistvu.Adresa,
                        Grad = s.ServisVisegRanga.PripadaPredstavnistvu.Grad

                    };

                    return sv;


                }

                else if (actualType == typeof(OvlasceniServisISalon))
                {
                    OvlasceniServisISalon s = session.Load<OvlasceniServisISalon>(idRadnje);
                    if(s.ServisVisegRanga == null)
                    {
                        throw new Exception("Salon nema servis viseg ranga!");
                    }
                    ServisVisegNizegRangaView sv = new()
                    {
                        Id = s.ServisVisegRanga.Id,
                        Adresa = s.ServisVisegRanga.PripadaPredstavnistvu.Adresa,
                        Grad = s.ServisVisegRanga.PripadaPredstavnistvu.Grad

                    };

                    return sv;
                }

                else
                {
                    throw new Exception("Radnja nije servis!");
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno vracanje servisa viseg ranga! " + ex.Message);
            }
        }

        public static List<ServisVisegNizegRangaView> servisiNizegRanga (int idRadnje)
        {
            List<ServisVisegNizegRangaView> sv = new List<ServisVisegNizegRangaView>();

            try
            {
                ISession session = DataLayer.GetSession();

                Radnja radnja = session.Load<Radnja>(idRadnje);
                Type actualType = NHibernateUtil.GetClass(radnja);

                if (actualType == typeof(OvlasceniServis))
                {
                    OvlasceniServis s = session.Load<OvlasceniServis>(idRadnje);
                    foreach(OvlasceniServis os in s.ServisiNizegRanga)
                    {
                        ServisVisegNizegRangaView servis = new()
                        {
                            Id = os.Id,
                            Adresa = os.PripadaPredstavnistvu.Adresa,
                            Grad = os.PripadaPredstavnistvu.Grad
                        };
                        sv.Add(servis);
                    }
                    

                    return sv;


                }

                else if (actualType == typeof(OvlasceniServisISalon))
                {
                    OvlasceniServisISalon s = session.Load<OvlasceniServisISalon>(idRadnje);
                    
                    foreach(Radnja os in s.ServisiNizegRanga)
                    {

                       
                        ServisVisegNizegRangaView servis = new()
                        {
                            Id = os.Id,
                            Adresa = os.PripadaPredstavnistvu.Adresa,
                            Grad = os.PripadaPredstavnistvu.Grad
                        };
                        sv.Add(servis);
                    }
                    return sv;
                }

                else
                {
                    throw new Exception("Radnja nije servis!");
                }


            }
            catch(Exception ex)
            {
                throw new Exception("Neuspesno vracanje servisa nizeg ranga! " + ex.Message);
            }
        }

        public static void DodajServis(ServisBasic servis)
        {
            try
            {
                ISession session = DataLayer.GetSession(); 
                if(session != null)
                {
                    Zaposleni sef;
                    if (servis.JmbgSefa != null)
                        sef = session.Load<Zaposleni>(servis.JmbgSefa);
                    else
                        sef = null;

                    Radnja servisVisegNivoa;
                    if(servis.IdServisaVsiegRanga != null)
                    {
                        servisVisegNivoa = session.Load<Radnja>(servis.IdServisaVsiegRanga);
                    }
                    else
                    {
                        servisVisegNivoa = null;
                    }

                    Predstavnistvo predstavnistvo = session.Load<Predstavnistvo>(servis.IdPredstavnistva);

                    OvlasceniServis noviServis = new()
                    {
                        StepenOpremljenosti = servis.StepenOpremljenosti,
                        Farbarske = servis.Farbarske,
                        Limarske = servis.Limarske,
                        Vulkanizerske = servis.Vulkanizerske,
                        Mehanicarske = servis.Mehanicarske,
                        SefRadnje = sef,
                        ServisVisegRanga = servisVisegNivoa,
                        PripadaPredstavnistvu = predstavnistvo
                    };
                    session.SaveOrUpdate(noviServis);
                    session.Flush();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno dodavanje servisa! " + ex.Message);
            }
        }

        public static void AzurirajServis(ServisBasic servis)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                if (session != null)
                {
                    //OvlasceniServis s = session.Load<OvlasceniServis>(servis.Id);
                    OvlasceniServis s = session.Query<OvlasceniServis>().FirstOrDefault(r => r.PripadaPredstavnistvu.Id == servis.IdPredstavnistva);
                    Zaposleni sef;
                    if (servis.JmbgSefa != null)
                        sef = session.Load<Zaposleni>(servis.JmbgSefa);
                    else
                        sef = null;

                    Radnja servisVisegNivoa;
                    if (servis.IdServisaVsiegRanga != null)
                    {
                        servisVisegNivoa = session.Load<Radnja>(servis.IdServisaVsiegRanga);
                    }
                    else
                    {
                        servisVisegNivoa = null;
                    }

                    s.StepenOpremljenosti = servis.StepenOpremljenosti;
                    s.Farbarske = servis.Farbarske;
                    s.Limarske = servis.Limarske;
                    s.Vulkanizerske = servis.Vulkanizerske;
                    s.Mehanicarske = servis.Mehanicarske;
                    s.SefRadnje = sef;
                    s.ServisVisegRanga = servisVisegNivoa;

                    session.SaveOrUpdate(s);
                    session.Flush();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno azuriranje servisa! " + ex.Message);
            }
        }

        public static void ObrisiRadnjuUPredstavnistvu(int idPredstavnistva)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                if (session != null)
                {
                    int idRadnje = session.Query<Radnja>().FirstOrDefault(r => r.PripadaPredstavnistvu.Id == idPredstavnistva).Id;

                    Radnja s = session.Load<OvlasceniServis>(idRadnje);
                    session.Delete(s);
                    session.Flush();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno brisanje radnje! " + ex.Message);
            }
        }

        public static void DodajServisISalon(ServisISalonBasic servisISalon)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                if (session != null)
                {
                    Zaposleni sef;
                    if (servisISalon.JmbgSefa != null)
                        sef = session.Load<Zaposleni>(servisISalon.JmbgSefa);
                    else
                        sef = null;

                    Radnja servisVisegNivoa;
                    if (servisISalon.IdServisaVsiegRanga != null)
                    {
                        servisVisegNivoa = session.Load<Radnja>(servisISalon.IdServisaVsiegRanga);
                    }
                    else
                    {
                        servisVisegNivoa = null;
                    }

                    Predstavnistvo predstavnistvo = session.Load<Predstavnistvo>(servisISalon.IdPredstavnistva);

                    OvlasceniServisISalon noviServis = new()
                    {
                        StepenOpremljenosti = servisISalon.StepenOpremljenosti,
                        Farbarske = servisISalon.Farbarske,
                        Limarske = servisISalon.Limarske,
                        Vulkanizerske = servisISalon.Vulkanizerske,
                        Mehanicarske = servisISalon.Mehanicarske,
                        SefRadnje = sef,
                        ServisVisegRanga = servisVisegNivoa,
                        PripadaPredstavnistvu = predstavnistvo
                    };
                    session.SaveOrUpdate(noviServis);
                    session.Flush();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno dodavanje servisa! " + ex.Message);
            }
        }
        public static void AzurirajServisISalon(ServisISalonBasic servisIS)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                if (session != null)
                {
                    OvlasceniServisISalon s = session.Query<OvlasceniServisISalon>().FirstOrDefault(r => r.PripadaPredstavnistvu.Id == servisIS.IdPredstavnistva);
                    Zaposleni sef;
                    if (servisIS.JmbgSefa != null)
                        sef = session.Load<Zaposleni>(servisIS.JmbgSefa);
                    else
                        sef = null;

                    Radnja servisVisegNivoa;
                    if (servisIS.IdServisaVsiegRanga != null)
                    {
                        servisVisegNivoa = session.Load<Radnja>(servisIS.IdServisaVsiegRanga);
                    }
                    else
                    {
                        servisVisegNivoa = null;
                    }

                    s.StepenOpremljenosti = servisIS.StepenOpremljenosti;
                    s.Farbarske = servisIS.Farbarske;
                    s.Limarske = servisIS.Limarske;
                    s.Vulkanizerske = servisIS.Vulkanizerske;
                    s.Mehanicarske = servisIS.Mehanicarske;
                    s.SefRadnje = sef;
                    s.ServisVisegRanga = servisVisegNivoa;

                    session.SaveOrUpdate(s);
                    session.Flush();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno azuriranje servisa! " + ex.Message);
            }
        }

        public static void DodajSalon(SalonBasic salon)
        {

            try
            {
                ISession session = DataLayer.GetSession();
                if (session != null)
                {
                    Zaposleni sef;
                    if (salon.JmbgSefa != null)
                        sef = session.Load<Zaposleni>(salon.JmbgSefa);
                    else
                        sef = null;
                    Predstavnistvo predstavnistvo = session.Load<Predstavnistvo>(salon.IdPredstavnistva);

                    Salon salon1 = new()
                    {
                        SefRadnje = sef,
                        PripadaPredstavnistvu = predstavnistvo
                    };

                    
                    session.SaveOrUpdate(salon1);
                    session.Flush();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno dodavanje salona! " + ex.Message);
            }
        }

        public static void AzurirajSalon(SalonBasic salon)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                if (session != null)
                {
                    Salon s = session.Query<Salon>().FirstOrDefault(r => r.PripadaPredstavnistvu.Id == salon.IdPredstavnistva);
                    Zaposleni sef;
                    if (salon.JmbgSefa != null)
                        sef = session.Load<Zaposleni>(salon.JmbgSefa);
                    else
                        sef = null;

                    s.SefRadnje = sef;

                    session.SaveOrUpdate(s);
                    session.Flush();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno azuriranje salona! " + ex.Message);
            }
        }
        public static bool PosedujeRadnju(int idPredstavnistva)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Radnja radnja = session.Query<Radnja>().FirstOrDefault(r => r.PripadaPredstavnistvu.Id == idPredstavnistva);

                if (radnja != null)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Neuspesno vracanje sadrzaja radnje! " + ex.Message);
            }
        }

            #endregion

            #region Vozilo

            public static List<VoziloBasic> vratiSvaVozila()
            {
                List<VoziloBasic> vozila = new List<VoziloBasic>();

                try
                {
                    ISession session = DataLayer.GetSession();

                    IEnumerable<Vozilo> vozilaIzBaze = from v in session.Query<Vozilo>()
                                                       select v;

                    

                    foreach (Vozilo v in vozilaIzBaze)
                    {
                        string vlasnistvo;

                        if(v.GetType() == typeof(NezavisnoVozilo))
                        {
                            vlasnistvo = "NezavisnoVozilo";
                        }
                        else
                        {
                        vlasnistvo = "VoziloKompanije";
                        }


                    vozila.Add(new VoziloBasic(v.BrojSasije, v.Boja, v.Model, v.TipGoriva, v.KubikazaMotora, v.BrojMotora, vlasnistvo));
                    }

                    session.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("Neuspesno vracanje vozila! " + ex.Message);
                }

                return vozila;
            }

            public static void obrisiVoziloKompanije(string brojSasije)
            {
                try
                {
                    ISession session = DataLayer.GetSession();

                    Vozilo vozilo = session.Load<Vozilo>(brojSasije);

                   // VoziloKompanije vozilokomp = session.Load<VoziloKompanije>(brojSasije);

                    //session.Delete(vozilokomp);
                    //session.Flush();





                    session.Delete(vozilo);
                    session.Flush();

                    session.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("Neuspesno brisanje vozila! " + ex.Message);
                }
            }


            public static void obrisiNezavisnoVozilo(string brojSasije)
            {
            try
            {
                ISession session = DataLayer.GetSession();

                Vozilo vozilo = session.Load<Vozilo>(brojSasije);

                //NezavisnoVozilo vozilonez = session.Load<NezavisnoVozilo>(brojSasije);

                //session.Delete(vozilonez);
               // session.Flush();





                session.Delete(vozilo);
                session.Flush();

                session.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno brisanje vozila! " + ex.Message);
            }
        }
    

            public static VoziloView prikaziVozilo(string brojSasije)
            {
                VoziloView voziloView = new VoziloView();

                try
                {
                    ISession session = DataLayer.GetSession();

                    Vozilo vozilo = session.Load<Vozilo>(brojSasije);

                    string vlasnsistvo;

                    if(vozilo.GetType() == typeof(NezavisnoVozilo))
                    {
                        vlasnsistvo = "NezavisnoVozilo";
                    }
                    else
                    {
                        
                        vlasnsistvo = "VoziloKompanije";
                    }
                    

                    voziloView.BrojSasije = vozilo.BrojSasije;
                    voziloView.Boja = vozilo.Boja;
                    voziloView.Model = vozilo.Model;
                    voziloView.TipGoriva = vozilo.TipGoriva;
                    voziloView.Kubikaza = vozilo.KubikazaMotora;
                    voziloView.BrojMotora = vozilo.BrojMotora;
                    voziloView.PutnickaF = vozilo.PutnickaF;
                    voziloView.BrojPutnika = vozilo.BrojPutnika;
                    voziloView.TeretnaF = vozilo.TeretnaF;
                    voziloView.Nosivost = vozilo.Nosivost;
                    voziloView.TeretniProstorOtvorenogTipa = vozilo.TeretniProstorOtvorenogTipa;
                    voziloView.VlasnistvoVozila = vlasnsistvo;

                    session.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("Neuspesno vracanje vozila! " + ex.Message);
                }

                return voziloView;
            }








            #endregion

            #region NezavisnoVozilo
            public static void dodajNezavisnoVozilo(NezavisnoVoziloBasic nezavisnoVoziloBasic)
            {
                try
                {
                    ISession session = DataLayer.GetSession();

                    NezavisnoVozilo nv = new()
                    {
                        BrojSasije = nezavisnoVoziloBasic.BrojSasije,
                        Boja = nezavisnoVoziloBasic.Boja,
                        Model = nezavisnoVoziloBasic.Model,
                        TipGoriva = nezavisnoVoziloBasic.TipGoriva,
                        KubikazaMotora = nezavisnoVoziloBasic.Kubikaza,
                        BrojMotora = nezavisnoVoziloBasic.BrojMotora,
                        PutnickaF = nezavisnoVoziloBasic.PutnickaF,
                        BrojPutnika = nezavisnoVoziloBasic.BrojPutnika,
                        TeretnaF = nezavisnoVoziloBasic.TeretnaF,
                        Nosivost = nezavisnoVoziloBasic.Nosivost,
                        TeretniProstorOtvorenogTipa = nezavisnoVoziloBasic.TeretniProstorOtvorenogTipa,
                        ImeVlasnika = nezavisnoVoziloBasic.ImeVlasnika,
                        PrezimeVlasnika = nezavisnoVoziloBasic.PrezimeVlasnika,
                        BrojTelefonaVlasnika = nezavisnoVoziloBasic.BrojTelefonaVlasnika

                    };

                    session.SaveOrUpdate(nv);

                    session.Flush();

                    session.Close();


                }
                catch (Exception ex)
                {
                    throw new Exception("Neuspesno dodavanje nezavisnog vozila! " + ex.Message);
                }
            }

            public static NezavisnoVoziloBasic vratiNezavisnoVozilo(string id)
            {
                NezavisnoVoziloBasic nv = new NezavisnoVoziloBasic();

                try
                {
                    ISession session = DataLayer.GetSession();

                    NezavisnoVozilo nezavisnoVozilo = session.Load<NezavisnoVozilo>(id);

                    nv.BrojSasije = nezavisnoVozilo.BrojSasije;
                    nv.Boja = nezavisnoVozilo.Boja;
                    nv.Model = nezavisnoVozilo.Model;
                    nv.TipGoriva = nezavisnoVozilo.TipGoriva;
                    nv.Kubikaza = nezavisnoVozilo.KubikazaMotora;
                    nv.BrojMotora = nezavisnoVozilo.BrojMotora;
                    nv.PutnickaF = nezavisnoVozilo.PutnickaF;
                    nv.BrojPutnika = nezavisnoVozilo.BrojPutnika;
                    nv.TeretnaF = nezavisnoVozilo.TeretnaF;
                    nv.Nosivost = nezavisnoVozilo.Nosivost;
                    nv.TeretniProstorOtvorenogTipa = nezavisnoVozilo.TeretniProstorOtvorenogTipa;
                    nv.ImeVlasnika = nezavisnoVozilo.ImeVlasnika;
                    nv.PrezimeVlasnika = nezavisnoVozilo.PrezimeVlasnika;
                    nv.BrojTelefonaVlasnika = nezavisnoVozilo.BrojTelefonaVlasnika;

                    session.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("Neuspesno vracanje nezavisnog vozila! " + ex.Message);
                }

                return nv;
        }

            #endregion

            #region VoziloKompanije

            public static void dodajVoziloKompanije(VoziloKompanijeBasic voziloKompanijeBasic)
            {
                try
                {
                    ISession session = DataLayer.GetSession();

                    Zaposleni zaposleni = session.Load<Zaposleni>(voziloKompanijeBasic.MbrIzvrsiocaPrijemaUvoza);

                    Radnja radnja = session.Load<Radnja>(voziloKompanijeBasic.IdSalona);


                    VoziloKompanije vk = new()
                    {
                        BrojSasije = voziloKompanijeBasic.BrojSasije,
                        Boja = voziloKompanijeBasic.Boja,
                        Model = voziloKompanijeBasic.Model,
                        TipGoriva = voziloKompanijeBasic.TipGoriva,
                        KubikazaMotora = voziloKompanijeBasic.Kubikaza,
                        BrojMotora = voziloKompanijeBasic.BrojMotora,
                        PutnickaF = voziloKompanijeBasic.PutnickaF,
                        BrojPutnika = voziloKompanijeBasic.BrojPutnika,
                        TeretnaF = voziloKompanijeBasic.TeretnaF,
                        Nosivost = voziloKompanijeBasic.Nosivost,
                        TeretniProstorOtvorenogTipa = voziloKompanijeBasic.TeretniProstorOtvorenogTipa,
                        UvezenoF = voziloKompanijeBasic.UvezenoF,
                        Datum_Uvoza = voziloKompanijeBasic.DatumUvoza,
                        MbrIzvrsiocaPrijemaUvoza = zaposleni,
                        IdSalona = radnja

                    };

                    zaposleni.UvezenaVozila.Add(vk);


                    if (radnja.GetType() == typeof(Salon))
                    {
                        Salon s = radnja as Salon;
                        s.IzlozenaVozila.Add(vk);
                    }

                    else if (radnja.GetType() == typeof(OvlasceniServisISalon))
                    {
                        OvlasceniServisISalon s = radnja as OvlasceniServisISalon;
                        s.IzlozenaVozila.Add(vk);
                    }




                    session.SaveOrUpdate(vk);

                    session.Flush();

                    session.Close();

                }

                catch (Exception ex)
                {
                    throw new Exception("Neuspesno dodavanje vozila kompanije! " + ex.Message);
                }
            }

            public static VoziloKompanijeBasic vratiVoziloKompanije(string id)
            {
                VoziloKompanijeBasic voziloKompanijeBasic = new VoziloKompanijeBasic();

                try
                {
                    ISession session = DataLayer.GetSession();
                    
                    VoziloKompanije voziloKompanije = session.Load<VoziloKompanije>(id);

                voziloKompanijeBasic.BrojSasije = voziloKompanije.BrojSasije;
                voziloKompanijeBasic.Boja = voziloKompanije.Boja;
                voziloKompanijeBasic.Model = voziloKompanije.Model;
                voziloKompanijeBasic.TipGoriva = voziloKompanije.TipGoriva;
                voziloKompanijeBasic.Kubikaza = voziloKompanije.KubikazaMotora;
                voziloKompanijeBasic.BrojMotora = voziloKompanije.BrojMotora;
                voziloKompanijeBasic.PutnickaF = voziloKompanije.PutnickaF;
                voziloKompanijeBasic.BrojPutnika = voziloKompanije.BrojPutnika;
                voziloKompanijeBasic.TeretnaF = voziloKompanije.TeretnaF;
                voziloKompanijeBasic.Nosivost = voziloKompanije.Nosivost;
                voziloKompanijeBasic.TeretniProstorOtvorenogTipa = voziloKompanije.TeretniProstorOtvorenogTipa;
                voziloKompanijeBasic.UvezenoF = voziloKompanije.UvezenoF;
                voziloKompanijeBasic.DatumUvoza = voziloKompanije.Datum_Uvoza;
                voziloKompanijeBasic.MbrIzvrsiocaPrijemaUvoza = voziloKompanije.MbrIzvrsiocaPrijemaUvoza.MaticniBroj;
                voziloKompanijeBasic.IdSalona = voziloKompanije.IdSalona.Id;

                session.Close();

            }

            catch (Exception ex)
            {
                throw new Exception("Neuspesno vracanje vozila kompanije! " + ex.Message);
            }

            return voziloKompanijeBasic;
        }


            #endregion

            #region ObavljeniServis

            public static List<ObavljeniServisBasic> vratiObavljeneServise()
            {
                List<ObavljeniServisBasic> ob = new List<ObavljeniServisBasic>();

                try
                {
                    ISession session = DataLayer.GetSession();

                    IEnumerable<JePrimljeno> obavljeniServisi = from o in session.Query<JePrimljeno>()
                                                                select o;

                    foreach (JePrimljeno o in obavljeniServisi)
                    {
                        ob.Add(new ObavljeniServisBasic(o.Id, o.RegistarskiBroj, o.Model, o.Opis, o.IdObavljenogServisa.MbrIzvrsiocaPrijema.MaticniBroj, o.GodinaProizvodnje, o.IdObavljenogServisa.Id));
                    }

                    session.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("Neuspesno vracanje obavljenih servisa! " + ex.Message);
                }

                return ob;

            }

            //promenio sam id da je string
            public static ObavljeniServisView vratiObavljeniServis(int id)
            {
                ObavljeniServisView osw = new ObavljeniServisView();

                try
                {
                    ISession session = DataLayer.GetSession();

                    JePrimljeno os = session.Load<JePrimljeno>(id);

                    osw.Id = os.Id;
                    osw.ServisId = os.Id;
                    osw.RegistarskiBroj = os.RegistarskiBroj;
                    osw.Opis = os.Opis;
                    osw.Model = os.Model;
                    osw.MbrIzvrsiocaPrijema = os.IdObavljenogServisa.MbrIzvrsiocaPrijema.MaticniBroj;
                    osw.GodinaProizvodnje = os.GodinaProizvodnje;
                    osw.DatumPrijema = os.IdObavljenogServisa.DatumPrjema;
                    osw.DatumZavrsetka = os.IdObavljenogServisa.DatumZavrsetka;
                    osw.AdresaServisa = os.IdObavljenogServisa.IdServisa.PripadaPredstavnistvu.Adresa;
                    osw.GradServisa = os.IdObavljenogServisa.IdServisa.PripadaPredstavnistvu.Grad;

                    session.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Neuspesno vracanje obavljenog servisa! " + ex.Message);
                }

                return osw;
            }

            public static void ObaviServis(ObavljeniServisCreate osc)
            {
                try
                {
                    ISession session = DataLayer.GetSession();

                    ObavljeniServis os = new ObavljeniServis
                    {
                        DatumPrjema = osc.DatumPrijemaVozila,
                        DatumZavrsetka = osc.DatumZavrsetkaServisa,
                        MbrIzvrsiocaPrijema = session.Load<Zaposleni>(osc.MbrIzvrsiocaPrijema),
                        IdServisa = session.Load<Radnja>(osc.ServisId)
                    };


                    session.SaveOrUpdate(os);

                    JePrimljeno jp = new JePrimljeno
                    {
                        RegistarskiBroj = osc.RegistarskiBroj,
                        Model = osc.Model,
                        Opis = osc.Opis,
                        GodinaProizvodnje = osc.GodinaProizvodnje,
                        IdObavljenogServisa = os,
                        BrojSasijeVozila = session.Load<Vozilo>(osc.BrojSasijeVozila)
                    };



                    os.JePrimljeno.Add(jp);

                    session.SaveOrUpdate(jp);

                    session.Flush();

                    session.Close();


                }

                catch (Exception ex)
                {
                    throw new Exception("Neuspesno obavljanje servisa! " + ex.Message);
                }
            }

            #endregion
        }

}

