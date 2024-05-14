using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;

namespace ProdajaMotornihVozila.Mapiranja
{
    class ZaposleniMapiranja: ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.MaticniBroj, "MATICNI_BROJ").GeneratedBy.Assigned();


            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLENJA");
            Map(x => x.StrucnaSprema, "STRUCNA_SPREMA");
            Map(x => x.TipZaposlenja, "TIP_ZAPOSLENJA");
            Map(x => x.Plata, "PLATA");
            Map(x => x.DatumIstekaUgovora, "DATUM_ISTEKA_UGOVORA");


        }
    }
}
