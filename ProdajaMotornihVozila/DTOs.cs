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

}
