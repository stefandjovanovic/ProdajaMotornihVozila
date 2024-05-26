using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public class VoziloKompanije : Vozilo
    {
        public virtual Radnja? IdSalona { get; set; }

        public virtual string? UvezenoF { get; set; }

        public virtual DateTime? Datum_Uvoza { get; set; }

        public virtual Zaposleni? MbrIzvrsiocaPrijemaUvoza { get; set; }





    }

 
}
