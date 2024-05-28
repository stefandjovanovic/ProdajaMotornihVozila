namespace ProdajaMotornihVozila.Entiteti
{
    public class ObavljeniServis
    {
        public virtual int Id { get; protected set; }
        public virtual required DateTime DatumPrjema { get; set; }
        public virtual DateTime? DatumZavrsetka { get; set; }

        public virtual required string RegistarskiBroj { get; set; }

        public virtual required string Model { get; set; }

        public virtual required string GodinaProizvodnje { get; set; }

        public virtual string? Opis { get; set; }


        public virtual required Zaposleni MbrIzvrsiocaPrijema { get; set; }

        public virtual required Radnja IdServisa { get; set; }

        public virtual required Vozilo PrimljenoVozilo { get; set; }



        public ObavljeniServis()
        {

        }
    }
}