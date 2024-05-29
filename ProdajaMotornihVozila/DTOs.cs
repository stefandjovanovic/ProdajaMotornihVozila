using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila
{
    #region Zaposleni
    public class ZaposleniBasic
    {
        public string ZaposleniId { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string StrucnaSprema { get; set; }

        public string TipZaposlenja { get; set; }

        public string TipStruke { get; set; }


        

        // dodatne informacije

        public ZaposleniBasic(string zaposleniId , string ime, string prezime, string? strucnaSprema, string tipZaposlenja, string tipstruke )
        {
            ZaposleniId = zaposleniId;
            Ime = ime;
            Prezime = prezime;
            StrucnaSprema = strucnaSprema;
            TipZaposlenja = tipZaposlenja;
            TipStruke = tipstruke;
        }

        public ZaposleniBasic()
        {
        }


    }

    public class ZaposleniView : ZaposleniBasic
    {
        public DateTime DatumRodjenja { get; set; }

        public DateTime DatumZaposlenja { get; set; }

        public float? Plata { get; set; }

        public DateTime? DatumIstekaUgovora { get; set; }

        public ZaposleniView() { }

        public ZaposleniView(string zaposleniId, string ime, string prezime, string strucnaSprema, string tipZaposlenja, string tipstruke, DateTime datumRodjenja, DateTime datumZaposlenja, float? plata, DateTime? datumIstekaUgovora) : base(zaposleniId, ime, prezime, strucnaSprema, tipZaposlenja, tipstruke)
        {
            DatumRodjenja = datumRodjenja;
            DatumZaposlenja = datumZaposlenja;
            Plata = plata;
            DatumIstekaUgovora = datumIstekaUgovora;
        }

    }

    public class TehnickeStrBasic : ZaposleniView
    {
        public string Institucija { get; set; }

        public string NazivSpecijalnosti { get; set; }

        public DateTime DatumSticanjaDiplome { get; set; }

        public TehnickeStrBasic(string zaposleniId, string ime, string prezime, string strucnaSprema, string tipZaposlenja, string tipstruke, DateTime datumRodjenja, DateTime datumZaposlenja, float? plata, DateTime? datumIstekaUgovora, string institucija, string nazivSpecijalnosti, DateTime datumSticanjaDiplome) 
        : base(zaposleniId, ime, prezime, strucnaSprema, tipZaposlenja, tipstruke, datumRodjenja, datumZaposlenja, plata, datumIstekaUgovora)
        {
            Institucija = institucija;
            NazivSpecijalnosti = nazivSpecijalnosti;
            DatumSticanjaDiplome = datumSticanjaDiplome;
        }

        public TehnickeStrBasic()
        {
        }

    }

    public class EkonomStrBasic : ZaposleniView
    {
        public string PosedujeSertifikat { get; set; }

        public DateTime? DatumSticanja { get; set; }

        public EkonomStrBasic(string zaposleniId, string ime, string prezime, string strucnaSprema , string tipZaposlenja, DateTime datumRodjenja, DateTime datumZaposlenja, float? plata, DateTime? datumIstekaUgovora, string tipstruke, string posedujeSertifikat, DateTime? datumSticanja) 
        : base (zaposleniId, ime, prezime, strucnaSprema, tipZaposlenja, tipstruke, datumRodjenja, datumZaposlenja, plata, datumIstekaUgovora)
        {
            PosedujeSertifikat = posedujeSertifikat;
            DatumSticanja = datumSticanja;
        }
        public EkonomStrBasic()
        {
        }

    }





    #endregion

    #region Predstavnistvo

    public class PredstavnistvoBasic
    {
        public int PredstavnistvoId { get; set; }

        public string Grad { get; set; }

        public string Adresa { get; set; }

        public string ImeDirektora { get; set; }

        public string PrezimeDirektora { get; set; }
        public string JmbgDirektora { get; set; }

        public PredstavnistvoBasic(int predstavnistvoId, string grad, string adresa, string imeDirektora, string prezimeDirektora, string jmbgDirektora)
        {
            PredstavnistvoId = predstavnistvoId;
            Grad = grad;
            Adresa = adresa;
            ImeDirektora = imeDirektora;
            PrezimeDirektora = prezimeDirektora;
            JmbgDirektora = jmbgDirektora;
        }

        public PredstavnistvoBasic()
        {
        }


    }


    public class PredstavnistvoView
    {
        public string Grad { get; set; }

        public string Adresa { get; set; }

        public string IdDirektora { get; set; }

        public PredstavnistvoView(string grad, string adresa, string idDirektora)
        {
            Grad = grad;
            Adresa = adresa;
            IdDirektora = idDirektora;
        }

        public PredstavnistvoView()
        { }
    }

    public class RadnjaView
    {
        public int Id { get; set; }
        public string? ImeSefa { get; set; }

        public string? PrezimeSefa { get; set; }
        public string? JmbgSefa { get; set; }

        public string SalonF { get; set; }

        public string ServisF { get; set; }

        public RadnjaView(int id, string imeSefa, string prezimeSefa, string salonF, string servisF)
        {
            Id = id;
            ImeSefa = imeSefa;
            PrezimeSefa = prezimeSefa;
            SalonF = salonF;
            ServisF = servisF;
        }

        public RadnjaView()
        { 
        }
    }

    public class ServisView
    {
        public int Id { get; set; }

        public string StepenOpremljenosti { get; set; }

        public string Farbarske { get; set; }

        public string Limarske { get; set; }

        public string Vulkanizerske { get; set; }

        public string Mehanicarske { get; set; }

        

        public ServisView(int id, string stepenOpremljenosti, string farbarske, string limarske, string vulkanizerske, string mehanicarske)
        {
            Id = id;
            StepenOpremljenosti = stepenOpremljenosti;
            Farbarske = farbarske;
            Limarske = limarske;
            Vulkanizerske = vulkanizerske;
            Mehanicarske = mehanicarske;
        }

        public ServisView()
        { }


    }


    public class ServisVisegNizegRangaView
    {
        public int Id { get; set; }

        public string Adresa { get; set; }

        public string Grad { get; set; }

        public ServisVisegNizegRangaView(int id, string adresa, string grad)
        {
            Id = id;
            Adresa = adresa;
            Grad = grad;
        }

        public ServisVisegNizegRangaView()
        { }
    }

    public class ServisBasic
    {
        public int IdPredstavnistva { get; set; }

        public string StepenOpremljenosti { get; set; }

        public string Farbarske { get; set; }

        public string Limarske { get; set; }

        public string Vulkanizerske { get; set; }

        public string Mehanicarske { get; set; }
        public string? JmbgSefa { get; set; }
        public int? IdServisaVsiegRanga { get; set; }

        public ServisBasic(int id, string stepenOpremljenosti, string farbarske, string limarske, string vulkanizerske, string mehanicarske, string? jmmbgSefa, int? idServisaVisegRanga)
        {
            IdPredstavnistva = id;
            StepenOpremljenosti = stepenOpremljenosti;
            Farbarske = farbarske;
            Limarske = limarske;
            Vulkanizerske = vulkanizerske;
            Mehanicarske = mehanicarske;
            JmbgSefa = jmmbgSefa;
            IdServisaVsiegRanga = idServisaVisegRanga;
        }

        public ServisBasic()
        {
        }
    }
    public class ServisISalonBasic : ServisBasic
    {
        public ServisISalonBasic(int id, string stepenOpremljenosti, string farbarske, string limarske, string vulkanizerske, string mehanicarske, string? jmbgSefa, int? idServisaVsiegRanga) 
            : base(id, stepenOpremljenosti, farbarske, limarske, vulkanizerske, mehanicarske, jmbgSefa, idServisaVsiegRanga)
        {
        }
        public ServisISalonBasic() { }
    }

    public class SalonBasic
    {
        public int IdPredstavnistva { get; set; }

        public string? JmbgSefa { get; set; }

        public SalonBasic(int id, string? jmbgSefa)
        {
            IdPredstavnistva = id;
            JmbgSefa = jmbgSefa;
        }

        public SalonBasic()
        {
        }
    }

    #endregion

    #region Vozila

    public class VoziloBasic
    {
        public string BrojSasije { get; set; }

        public string Boja { get; set; }

        public string Model { get; set; }

        public string TipGoriva { get; set; }

        public int Kubikaza { get; set; }

        public string BrojMotora { get; set; }

        public string VlasnistvoVozila { get; set; }


        public VoziloBasic(string brojSasije, string boja, string model, string tipGoriva, int kubikaza, string brojMotora, string vlasnistvoVozila)
        {
            BrojSasije = brojSasije;
            Boja = boja;
            Model = model;
            TipGoriva = tipGoriva;
            Kubikaza = kubikaza;
            BrojMotora = brojMotora;
            VlasnistvoVozila = vlasnistvoVozila;
        }

        public VoziloBasic()
        {
        }

    }

    public class VoziloView : VoziloBasic
    {
        public string PutnickaF { get; set; }

        public int? BrojPutnika { get; set; }

        public string TeretnaF { get; set; }

        public int? Nosivost { get; set; }

        public string TeretniProstorOtvorenogTipa { get; set; }

        


        public VoziloView(string brojSasije, string boja, string model, string tipGoriva, int kubikaza, string brojMotora, string putnickaF, int brojPutnika, string teretnaF, int nosivost, string teretniProstorOtvorenogTipa, string vlasnistvo) : base(brojSasije, boja, model, tipGoriva, kubikaza, brojMotora, vlasnistvo)
            
        {
            PutnickaF = putnickaF;
            BrojPutnika = brojPutnika;
            TeretnaF = teretnaF;
            Nosivost = nosivost;
            TeretniProstorOtvorenogTipa = teretniProstorOtvorenogTipa;
            
        }

        public VoziloView()
        {
        }

    }

    public class  NezavisnoVoziloBasic : VoziloView
    {
        public string ImeVlasnika { get; set; }

        public string PrezimeVlasnika { get; set; }

        public string BrojTelefonaVlasnika { get; set; }

        public NezavisnoVoziloBasic(string brojSasije, string boja, string model, string tipGoriva, int kubikaza, string brojMotora, string putnickaF, int brojPutnika, string teretnaF, int nosivost, string teretniProstorOtvorenogTipa, string imeVlasnika, string prezimeVlasnika, string brojTelefonaVlasnika, string vlasnistvo): base(brojSasije, boja, model, tipGoriva, kubikaza, brojMotora, putnickaF, brojPutnika, teretnaF, nosivost, teretniProstorOtvorenogTipa, vlasnistvo)
        {
            ImeVlasnika = imeVlasnika;
            PrezimeVlasnika = prezimeVlasnika;
            BrojTelefonaVlasnika = brojTelefonaVlasnika;
        }

        public NezavisnoVoziloBasic()
        {
        }

    }

    public class VoziloKompanijeBasic : VoziloView
    {
        public string UvezenoF { get; set; }

        public int IdSalona { get; set; }

        public string MbrIzvrsiocaPrijemaUvoza { get; set; }

        public DateTime? DatumUvoza { get; set; }


        public VoziloKompanijeBasic(string brojSasije, string boja, string model, string tipGoriva, int kubikaza, string brojMotora, string putnickaF, int brojPutnika, string teretnaF, int nosivost, string teretniProstorOtvorenogTipa, string uvezenoF, int idSalona, string mbrIzvrsiocaPrijemaUvoza, DateTime datumUvoza, string vlasnistvo) : base(brojSasije, boja, model, tipGoriva, kubikaza, brojMotora, putnickaF, brojPutnika, teretnaF, nosivost, teretniProstorOtvorenogTipa, vlasnistvo)
        {
            UvezenoF = uvezenoF;
            IdSalona = idSalona;
            MbrIzvrsiocaPrijemaUvoza = mbrIzvrsiocaPrijemaUvoza;
            DatumUvoza = datumUvoza;
        }

        public VoziloKompanijeBasic()
        {
        }


    }

    #endregion

    #region ObavljeniServis

    public class ObavljeniServisBasic
    {
        public int Id { get; set; }

        public int ServisId { get; set; }

        public string RegistarskiBroj { get; set; }

        public string Model { get; set; }

        public string Opis { get; set; }

        public string MbrIzvrsiocaPrijema { get; set; }

        public string GodinaProizvodnje { get; set; }


        public ObavljeniServisBasic(int id, string registarskiBroj, string model, string opis, string mbrIzvrsiocaPrijema, string godinaprozivodnja, int servisId)
        {
            Id = id;
            RegistarskiBroj = registarskiBroj;
            Model = model;
            Opis = opis;
            MbrIzvrsiocaPrijema = mbrIzvrsiocaPrijema;
            GodinaProizvodnje = godinaprozivodnja;
            ServisId = servisId;
        }

        public ObavljeniServisBasic()
        {
        }
    }

    public class ObavljeniServisView : ObavljeniServisBasic
    {
        public DateTime DatumPrijema { get; set; }

        public DateTime? DatumZavrsetka { get; set; }

        public string AdresaServisa { get; set; }

        public string GradServisa { get; set; }
        public string BrojSasijeVozila { get; set; }

        public ObavljeniServisView(int id, string registarskiBroj, string model, string opis, string mbrIzvrsiocaPrijema, string godinaProizvodnje, int servisId, DateTime datumPrijema, DateTime datumZavrsetka, string adresaServisa, string gradServisa, string brojSasije) 
            : base(id, registarskiBroj, model, opis, mbrIzvrsiocaPrijema, godinaProizvodnje, servisId)
        {
            DatumPrijema = datumPrijema;
            DatumZavrsetka = datumZavrsetka;
            AdresaServisa = adresaServisa;
            GradServisa = gradServisa;
            BrojSasijeVozila = brojSasije;
        }

        public ObavljeniServisView()
        {
        }

    }

    public class ObavljeniServisCreate : ObavljeniServisBasic
    {
        public string BrojSasijeVozila { get; set; }

        public DateTime DatumPrijemaVozila { get; set; }

        public DateTime? DatumZavrsetkaServisa { get; set; }

        public ObavljeniServisCreate(int id, string registarskiBroj, string model, string opis, string mbrIzvrsiocaPrijema, string godinaProizvodnje, int servisId, string brojSasijeVozila, DateTime datumPrijemaVozila, DateTime? datumZavrsetkaServisa) 
            : base(id, registarskiBroj, model, opis, mbrIzvrsiocaPrijema, godinaProizvodnje, servisId)
        {
            BrojSasijeVozila = brojSasijeVozila;
            DatumPrijemaVozila = datumPrijemaVozila;
            DatumZavrsetkaServisa = datumZavrsetkaServisa;
        }

        public ObavljeniServisCreate()
        {
        }
    }

    #endregion

    #region Prodaja

    public class ProdajaBasic
    {
        public int? Id { get; set; }
        public string? BrojSasije { get; set; }
        public int? IdKupca { get; set; }
        public int? IdMestaProdaje { get; set; }
        public string? MBRProdavca { get; set; }
        public string? TipKupca { get; set; }

        public ProdajaBasic(int id, string brojSasije, int idKupca, int idMestaProdaje, string mBRIzvrsioca, string tipKupca)
        {
            Id = id;
            BrojSasije = brojSasije;
            IdKupca = idKupca;
            IdMestaProdaje = idMestaProdaje;
            MBRProdavca = mBRIzvrsioca;
            TipKupca = tipKupca;
        }
        public ProdajaBasic()
        {

        }
    }
    public class ProdajaView : ProdajaBasic
    {
        public string ImeKupca { get; set; }
        public string PrezimeKupca { get; set; }
        public string BrojTelefona { get; set; }
        public string AdresaSalona { get; set; }
        public string GradSalona { get; set; }
        public string ImeProdavca { get; set; }
        public string PrezimeProdavca { get; set; }
        public string ModelVozila { get; set; }

        public string Pib { get; set; }

        public string MBRKupca { get; set; }

        public ProdajaView(int id, string brojSasije, int idKupca, int idMestaProdaje, string mBRIzvrsioca, string tipKupca, string ime, string prezime, string brTel, string adresaSalona, string gradSalona, string imeProdavca, string prezimeProdavca, string modelVozila, string pib, string mbrkupca)
            : base(id, brojSasije, idKupca, idMestaProdaje, mBRIzvrsioca, tipKupca)
        {
            ImeKupca = ime;
            PrezimeKupca = prezime;
            BrojTelefona = brTel;
            AdresaSalona = adresaSalona;
            GradSalona = gradSalona;
            ImeProdavca = imeProdavca;
            PrezimeProdavca = prezimeProdavca;
            ModelVozila = modelVozila;
            Pib = pib;
            MBRKupca = mbrkupca;
        }
        public ProdajaView()
        {

        }
        
    }
    public class KupacBasic
    {
        public int Id { get; set; } //stavi na -1 ako se kreira novi
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string TipKupca { get; set; } //Pravno ili Fizicko
        public string? Pib { get; set; }
        public string? MaticniBroj { get; set; }

        public KupacBasic(int id, string ime, string prezime, string brojTelefona, string tipKupca, string? pib, string? maticniBroj)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            BrojTelefona = brojTelefona;
            TipKupca = tipKupca;
            Pib = pib;
            MaticniBroj = maticniBroj;
        }
        public KupacBasic()
        {

        }
    }
    public class ProdajaCreate : ProdajaBasic
    {
        public KupacBasic Kupac { get; set; }
        public ProdajaCreate(int id, string brojSasije, int idKupca, int idMestaProdaje, string mBRIzvrsioca, string tipKupca, KupacBasic kupac)
            : base(id, brojSasije, idKupca, idMestaProdaje, mBRIzvrsioca, tipKupca)
        {
            Kupac = kupac;
        }

        public ProdajaCreate()
        {

        }
    }

    

    #endregion
}
