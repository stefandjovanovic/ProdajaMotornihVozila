using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            Table("VOZILO");

            Id(x => x.BrojSasije, "BROJ_SASIJE").GeneratedBy.Assigned();

            Map(x => x.Boja, "BOJA");
            Map(x => x.Model, "MODEL");
            Map(x => x.TipGoriva, "TIP_GORIVA");
            Map(x => x.KubikazaMotora, "KUBIKAZA_MOTORA");
            Map(x => x.PutnickaF, "PUTNICKA_F");
            Map(x => x.BrojMotora, "BROJ_MOTORA");
            Map(x => x.BrojPutnika, "BROJ_PUTNIKA");
            Map(x => x.TeretnaF, "TERETNA_F");
            Map(x => x.Nosivost, "NOSIVOST");
            Map(x => x.TeretniProstorOtvorenogTipa, "TERETNI_PROSTOR_OTVORENOG_TIPA");

            HasMany(x => x.ObavljeniServisi)
                .KeyColumn("BROJ_SASIJE")
                .Inverse()
                .Cascade.All();

        }
    }
}
