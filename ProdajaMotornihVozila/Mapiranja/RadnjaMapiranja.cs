﻿using FluentNHibernate.Mapping;
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

            DiscriminateSubClassesOnColumn("").Formula("(CASE WHEN (OVLASCENI_SERVIS_F = 'Da' AND SALON_F = 'Ne' ) " +
                "THEN 'Servis'" +
                " WHEN (OVLASCENI_SERVIS_F = 'Ne' AND SALON_F = 'Da' )" +
                " THEN 'Salon' " +
                "WHEN (OVLASCENI_SERVIS_F = 'Da' AND SALON_F = 'Da' ) THEN " +
                "'ServisSalon'" +
                "ELSE 'Nepoznato'" +
                "END)");


            References(x => x.PripadaPredstavnistvu).Column("ID_PREDSTAVNISTVA").LazyLoad();
            References(x => x.SefRadnje).Column("MATICNI_BROJ_SEFA").LazyLoad();

            HasMany(x => x.ZaposleniURadnji).KeyColumn("ID_RADNJE_ANGAZOVANJA").Cascade.All().Inverse();

            
        }
    }

    public class OvlasceniServisMapiranja : SubclassMap<OvlasceniServis>
    {

        public OvlasceniServisMapiranja()
        {
            DiscriminatorValue("Servis");

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
        public SalonMapiranja()
        {
            DiscriminatorValue("Salon");

            HasMany(x => x.ProdataVozila).KeyColumn("ID_MESTA_PRODAJE").Cascade.All().Inverse();
        }
    }

    public class OvlasceniServiIRadnjaMapiranja : SubclassMap<OvlasceniServisISalon>
    {
        public OvlasceniServiIRadnjaMapiranja()
        {
            DiscriminatorValue("ServisSalon");

            Map(x => x.StepenOpremljenosti, "STEPEN_OPREMLJENOSTI");
            Map(x => x.Farbarske, "FARBARSKE");
            Map(x => x.Limarske, "LIMARSKE");
            Map(x => x.Vulkanizerske, "VULKANICARSKE");
            Map(x => x.Mehanicarske, "MEHANICARSKE");

            References(x => x.ServisVisegRanga).Column("ID_SERVISA_VISEG_RANGA").LazyLoad();
            HasMany(x => x.ServisiNizegRanga).KeyColumn("ID_SERVISA_VISEG_RANGA").Cascade.All().Inverse();
        }
    }

}