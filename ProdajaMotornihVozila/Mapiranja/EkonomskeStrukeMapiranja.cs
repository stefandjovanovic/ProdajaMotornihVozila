﻿using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class EkonomskeStrukeMapiranja : SubclassMap<EkonomskeStruke>
    {
        public EkonomskeStrukeMapiranja()
        {
            KeyColumn("MATICNI_BROJ");
        }
    }
}
