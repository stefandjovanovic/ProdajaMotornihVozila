using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class RadnjaMapiranja : ClassMap<Radnja>
    {
        public RadnjaMapiranja()
        {
            Table("RADNJA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("").Formula("predikat");


            References(x => x.PripadaPredstavnistvu).Column("ID_PREDSTAVNISTVA").LazyLoad();
            References(x => x.SefRadnje).Column("MATICNI_BROJ_SEFA").LazyLoad();

            HasMany(x => x.ZaposleniURadnji).KeyColumn("ID_RADNJE_ANGAZOVANJA").Cascade.All().Inverse();

            
        }
    }

    public class OvlasceniServisMapiranja : SubclassMap<OvlasceniServis>
    {

        public OvlasceniServisMapiranja()
        {
            DiscriminatorValue("Da");

            Map(x => x.StepenOpremljenosti, "STEPEN_OPREMLJENOSTI");
            Map(x => x.Farbarske, "FARBARSKE");
            Map(x => x.Limarske, "LIMARSKE");
            Map(x => x.Vulkanizerske, "VULKANICARSKE");
            Map(x => x.Mehanicarske, "MEHANICARSKE");

            References(x => x.ServisVisegRanga).Column("ID_SERVISA_VISEG_RANGA").LazyLoad();
            HasMany(x => x.ServisiNizegRanga).KeyColumn("ID_SERVISA_VISEG_RANGA").Cascade.All().Inverse();
        }
       
    }

    public class SalonMapiranja : SubclassMap<Salon>
    {

    }
}
