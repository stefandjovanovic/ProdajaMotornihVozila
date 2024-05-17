using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class ProdajaVozilaMapiranja : ClassMap<ProdajaVozila>
    {
        public ProdajaVozilaMapiranja()
        {
            Table("PRODAJA_VOZILA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.MestoProdaje).Column("ID_MESTA_PRODAJE").LazyLoad();
            References(x => x.IzvrsioProdaju).Column("MATICNI_BROJ_POSLODAVCA").LazyLoad();
            References(x => x.KupacVozila).Column("ID_KUPCA");

        }
    }
}
