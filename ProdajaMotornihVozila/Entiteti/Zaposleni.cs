using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public abstract class Zaposleni
    {
        public virtual required string MaticniBroj { get; set; }
        public virtual required string Ime { get; set; }
        public virtual required string Prezime { get; set; }
        public virtual required DateTime  DatumRodjenja { get; set; }
        public virtual required DateTime  DatumZaposlenja { get; set; }
        public virtual string? StrucnaSprema { get; set; }
        //public virtual required string TipZaposlenja { get; set; }
        

        public virtual Radnja? RadnjaAngazovanja { get; set; }

        public virtual Zaposleni? RukovodiocZaposlenog { get; set; }

        public virtual IList<Zaposleni>? PodredjeniZaposleni { get; set; } = [];


    }

    public class StalnoZaposleni: Zaposleni
    {
        public virtual float? Plata { get; set; }
    }

    public class ZaposleniNaOdredjeno: Zaposleni
    {
        public virtual DateTime? DatumIstekaUgovora { get; set; }
    }
}
