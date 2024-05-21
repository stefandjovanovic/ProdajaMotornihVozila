using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public class EkonomskeStruke : Zaposleni
    {
        public virtual required string PosedujeSertifikat { get; set; }

        public virtual DateTime? DatumSticanja { get; set; }


    }
}
