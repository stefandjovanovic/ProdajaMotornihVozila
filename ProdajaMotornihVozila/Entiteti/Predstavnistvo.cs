using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public class Predstavnistvo
    {
        public virtual int Id { get; protected set; }
        public virtual required string Grad { get; set; }
        public virtual required string Adresa { get; set; }

        public virtual required Zaposleni Direktor { get; set; }

    }
}
