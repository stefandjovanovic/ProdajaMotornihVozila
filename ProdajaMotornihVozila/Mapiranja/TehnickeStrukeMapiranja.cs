using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class TehnickeStrukeMapiranja : SubclassMap<TehnickeStruke>
    {
        public TehnickeStrukeMapiranja()
        {
            Table("TEHNICKE_STRUKE");

            KeyColumn("MATICNI_BROJ");

            Map(x => x.NazivSpecijalnosti, "NAZIV");
            Map(x => x.DatumSticanjaDiplome, "DATUM_STICANJA");
            Map(x => x.Institucija, "INSTITUCIJA");
           
        }
    }
    

}
