using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class PredstavnistvoMapiranja : ClassMap<Predstavnistvo>
    {
        public PredstavnistvoMapiranja()
        {
            Table("PREDSTAVNISTVO");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Grad, "GRAD");
            Map(x => x.Adresa, "ADRESA");

            References(x => x.Direktor).Column("MATICNI_BROJ_DIREKTORA").LazyLoad();
        }
    }
}
