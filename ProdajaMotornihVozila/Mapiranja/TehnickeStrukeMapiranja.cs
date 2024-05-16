using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class TehnickeStrukeStalnoMapiranja : SubclassMap<TehnickeStrukeStalno>
    {
        public TehnickeStrukeStalnoMapiranja()
        {
            Table("TEHNICKE_STRUKE");

            KeyColumn("MATICNI_BROJ");

            Map(x => x.NazivSpecijalnosti, "NAZIV");
            Map(x => x.Institucija, "INSTITUCIJA");
            Map(x => x.DatumSticanjaDiplome, "DATUM");
        }
    }
    public class TehnickeStrukeNaOdredjenoMapiranja : SubclassMap<TehnickeStrukeNaOdredjeno>
    {
        public TehnickeStrukeNaOdredjenoMapiranja()
        {
            Table("TEHNICKE_STRUKE");

            KeyColumn("MATICNI_BROJ");

            Map(x => x.NazivSpecijalnosti, "NAZIV");
            Map(x => x.Institucija, "INSTITUCIJA");
            Map(x => x.DatumSticanjaDiplome, "DATUM");
        }
    }

}
