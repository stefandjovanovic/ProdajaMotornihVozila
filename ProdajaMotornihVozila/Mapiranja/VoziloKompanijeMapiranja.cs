using FluentNHibernate.Mapping;
using ProdajaMotornihVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Mapiranja
{
    public class VoziloKompanijeMapiranja : SubclassMap<VoziloKompanije>
    {
        //ajde dovrsi ovo
        public VoziloKompanijeMapiranja()
        {
            Table("VOZILO_KOMPANIJE");

            KeyColumn("BROJ_SASIJE");

            DiscriminatorValue("Ne");



            Map(x => x.UvezenoF, "UVEZENO_F");

            Map(x => x.Datum_Uvoza, "DATUM_UVOZA");

            References(x => x.IdSalona, "ID_SALONA").LazyLoad();

            References(x => x.MbrIzvrsiocaPrijemaUvoza, "MBR_IZVRSIOCA_PRIJEMA_UVOZA").LazyLoad();


        }
    }

    
}