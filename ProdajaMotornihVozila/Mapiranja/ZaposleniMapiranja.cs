using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class ZaposleniMapiranja: ClassMap<Zaposleni>
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



            References(x => x.RadnjaAngazovanja).Column("ID_RADNJE_ANGAZOVANJA").LazyLoad();

            References(x => x.RukovodiocZaposlenog).Column("MATICNI_BROJ_RUKOVODIOCA").LazyLoad();

            HasMany(x => x.PodredjeniZaposleni).KeyColumn("MATICNI_BROJ_RUKOVODIOCA").Cascade.All().Inverse();
            HasMany(x => x.IzvrseneProdaje).KeyColumn("MATICNI_BROJ_POSLODAVCA").Cascade.All().Inverse();
        }
    }

}
