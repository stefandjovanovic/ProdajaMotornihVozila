using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class JePrimljenoMapiranja : ClassMap<JePrimljeno>
    {
        public JePrimljenoMapiranja()
        {
            Table("JE_PRIMLJENO");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //Map(x => x.IdObavljenogServisa, "ID_OBAVLJENOG_SERVISA");
            //Map(x => x.RegistarskiBroj, "REGISTARSKI_BROJ");
            Map(x => x.Model, "MODEL");
            Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");
            Map(x => x.Opis, "OPIS");

            References(x => x.RegistarskiBroj, "REGISTARSKI_BROJ").LazyLoad();
            References(x => x.IdObavljenogServisa, "ID_OBAVLJENOG_SERVISA").LazyLoad();




        }
    }
}