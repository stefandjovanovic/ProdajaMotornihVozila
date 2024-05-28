using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public abstract class Radnja
    {
        public virtual int Id { get; protected set; }

        public virtual string? SalonF { get; protected set; }
        public virtual string? ServisF { get; protected set; }


        public virtual Predstavnistvo? PripadaPredstavnistvu { get; set; }
        public virtual Zaposleni? SefRadnje {  get; set; }

        public virtual IList<Zaposleni>? ZaposleniURadnji { get; set; } = [];

        public virtual IList<ObavljeniServis> ObavljeniServisiURadnji { get; set; } = [];


    }

    public class OvlasceniServis: Radnja
    {
        public virtual string? StepenOpremljenosti { get; set; }
        public virtual string? Farbarske { get; set; }
        public virtual string? Limarske { get; set; }
        public virtual string? Vulkanizerske { get; set; }
        public virtual string? Mehanicarske { get; set; }

        public virtual Radnja? ServisVisegRanga { get; set; }
        public virtual IList<Radnja>? ServisiNizegRanga { get; set; } = [];
    }

    public class Salon: Radnja
    {
        public virtual IList<ProdajaVozila>? ProdataVozila { get; set; } = [];
        public virtual IList<VoziloKompanije>? IzlozenaVozila { get; set; } = [];
    }

    public class OvlasceniServisISalon: Radnja
    {
        public virtual string? StepenOpremljenosti { get; set; }
        public virtual string? Farbarske { get; set; }
        public virtual string? Limarske { get; set; }
        public virtual string? Vulkanizerske { get; set; }
        public virtual string? Mehanicarske { get; set; }

        public virtual Radnja? ServisVisegRanga { get; set; }
        public virtual IList<Radnja>? ServisiNizegRanga { get; set; } = [];

        public virtual IList<VoziloKompanije>? IzlozenaVozila { get; set; } = [];
    }

}
