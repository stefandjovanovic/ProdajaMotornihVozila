namespace ProdajaMotornihVozila.Entiteti
{
    public class ObavljeniServis
    {
        public virtual int Id { get; protected set; }
        public virtual required DateTime DatumPrjema { get; set; }
        public virtual DateTime? DatumZavrsetka { get; set; }

        public virtual required Zaposleni MbrIzvrsiocaPrijema { get; set; }

        public virtual required Radnja IdServisa { get; set; }

        public virtual IList<JePrimljeno>? JePrimljeno { get; set; }

        public ObavljeniServis()
        {
            JePrimljeno = new List<JePrimljeno>();
        }
    }
}