using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class KupacMapiranja : ClassMap<Kupac>
    {
        public KupacMapiranja()
        {
            Table("KUPAC");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("TIP_KUPCA");

            //Map(x => x.TipKupca, "TIP_KUPCA");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");

        }
    }
    public class PravnoLiceMapiranje : SubclassMap<PravnoLice>
    {
        public PravnoLiceMapiranje()
        {
            DiscriminatorValue("Pravno");

            Map(x => x.Pib, "PIB");
        }

    }

    public class FizickoLiceMapiranja : SubclassMap<FizickoLice>
    {
        public FizickoLiceMapiranja()
        {
            DiscriminatorValue("Fizicko");

            Map(x => x.MaticniBroj, "MATICNI_BROJ");
        }
    }

}
