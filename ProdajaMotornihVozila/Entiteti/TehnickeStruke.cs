﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public class TehnickeStrukeStalno : StalnoZaposleni
    {
        public virtual required string Institucija { get; set; }
        public virtual required string NazivSpecijalnosti { get; set; }
        public virtual required DateTime DatumSticanjaDiplome { get; set; }
    }

    public class TehnickeStrukeNaOdredjeno: ZaposleniNaOdredjeno
    {
        public virtual required string Institucija { get; set; }
        public virtual required string NazivSpecijalnosti { get; set; }
        public virtual required DateTime DatumSticanjaDiplome { get; set; }
    }
}
