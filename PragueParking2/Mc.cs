namespace PragueParking2
{
    public class Mc : Vehicle
    {
        public Mc(string regNumber) : base(regNumber)
        {
            Size = 2;   // TODO: skall hämtas från konfigurationsfil
            PricePerHour = 10; //TODO: också från konfigfil
        }
    }
}