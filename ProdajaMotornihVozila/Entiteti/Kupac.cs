using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMotornihVozila.Entiteti
{
    public abstract class Kupac
    {
        public virtual int Id { get; protected set; }
        public virtual required string  Ime { get;  set; }
        public virtual required string Prezime { get; set; }
        public virtual required string BrojTelefona { get; set; }
        public virtual required string TipKupca { get; set; }

    }

    public class PravnoLice : Kupac
    { 
        public virtual string? Pib {  get; set; }
    }

    public class FizickoLice : Kupac
    {
        public virtual string? MaticniBroj { get; set; }
    }

}
