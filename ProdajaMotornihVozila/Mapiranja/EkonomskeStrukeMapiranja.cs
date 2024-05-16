using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class EkonomskeStrukeStalnoMapiranja : SubclassMap<EkonomskeStrukeStalno>
    {
        public EkonomskeStrukeStalnoMapiranja()
        {
            Table("EKONOMSKE_STRUKE");


            KeyColumn("MATICNI_BROJ");
        }
    }

    public class EkonomskeStrukeNaOdredjenoMapiranja : SubclassMap<EkonomskeStrukeNaOdredjeno>
    {
        public EkonomskeStrukeNaOdredjenoMapiranja()
        {
            Table("EKONOMSKE_STRUKE");

            KeyColumn("MATICNI_BROJ");
        }
    }
}
