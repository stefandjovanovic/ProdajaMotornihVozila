using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class NezavisnoVoziloMapiranje : SubclassMap<NezavisnoVozilo>
    {
        public NezavisnoVoziloMapiranje()
        {
            Table("NEZAVISNO_VOZILO");

            KeyColumn("BROJ_SASIJE");

            Map(x => x.ImeVlasnika, "IME_VLASNIKA");
            Map(x => x.PrezimeVlasnika, "PREZIME_VLASNIKA");
            Map(x => x.BrojTelefonaVlasnika, "BROJ_TELEFONA_VLASNIKA");
        }

    }
}