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

            Map(x => x.DatumPrjema, "DATUM_PRIJEMA");
            Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");
            Map(x => x.Model, "MODEL");
            Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");
            Map(x => x.Opis, "OPIS");
            Map(x => x.RegistarskiBroj, "REGISTARSKI_BROJ");


            References(x => x.MbrIzvrsiocaPrijema).Column("MBR_IZVRSIOCA_PRIJEMA").LazyLoad();
            References(x => x.PrimljenoVozilo, "BROJ_SASIJE").LazyLoad();
            References(x => x.IdServisa, "ID_SERVISA").LazyLoad();

        }
    }
}