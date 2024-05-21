using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public class JePrimljeno
    {
        public virtual int Id { get; protected set; }

        public virtual required ObavljeniServis IdObavljenogServisa { get; set; }

        public virtual required Vozilo RegistarskiBroj { get; set; }

        public virtual required string Model { get; set; }

        public virtual required string GodinaProizvodnje { get; set; }

        public virtual required string Opis { get; set; }
    }
}
