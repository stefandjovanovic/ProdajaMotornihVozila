using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public class ProdajaVozila
    {
        public virtual int Id { get; protected set; }

        public virtual Salon? MestoProdaje { get; set; }
        public virtual Zaposleni? IzvrsioProdaju { get; set; }
        public virtual Kupac? KupacVozila { get; set; }
    }
}
