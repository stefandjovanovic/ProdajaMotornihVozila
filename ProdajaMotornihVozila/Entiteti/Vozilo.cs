using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public abstract class Vozilo
    {
        public virtual required string BrojSasije { get; set; }

        public virtual required string Boja { get; set; }

        public virtual required string Model { get; set; }

        public virtual required string TipGoriva { get; set; }

        public virtual required int KubikazaMotora { get; set; }

        public virtual string? PutnickaF { get; set; }

        public virtual int? BrojPutnika { get; set; }

        public virtual string? TeretnaF { get; set; }

        public virtual int? Nosivost { get; set; }

        public virtual string? TeretniProstorOtvorenogTipa { get; set; }


        public virtual IList<JePrimljeno>? JePrimljeno { get; set; }

        public Vozilo()
        {
            JePrimljeno = new List<JePrimljeno>();
        }
    }
}
