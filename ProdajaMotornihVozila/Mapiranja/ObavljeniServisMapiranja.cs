using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class ObavljeniServisMapiranja : ClassMap<ObavljeniServis>
    {
        public ObavljeniServisMapiranja()
        {
            Table("OBAVLJENI_SERVIS");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumPrjema, "DATUM_PRJEMA");
            Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");
            //Map(x => x.MbrIzvrsiocaPrijema, "MBR_IZVRIOCA_PRIJEMA");
            //Map(x => x.IdServisa, "ID_SERVISA");

            References(x => x.MbrIzvrsiocaPrijema).Column("MBR_IZVRIOCA_PRIJEMA").LazyLoad();

            HasMany(x => x.JePrimljeno)
                .KeyColumn("ID_OBAVLJENOG_SERVISA")
                .Cascade.All();
        }
    }
}