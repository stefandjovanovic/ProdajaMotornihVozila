using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public class NezavisnoVozilo : Vozilo
    {
        public virtual required string ImeVlasnika { get; set; }

        public virtual required string PrezimeVlasnika { get; set; }

        public virtual required string BrojTelefonaVlasnika { get; set; }
    }
}
