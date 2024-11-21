namespace PragueParking2
{
    public class Vehicle
    {
        public string? RegNumber { get; set; }
        public int Size { get; set; }
        public DateTime Arrival { get; set; } = DateTime.Now;
        public int PricePerHour { get; set; }
        public Vehicle(string regNumber)
        {
            RegNumber = regNumber;
        }
        
        // TODO: vi kommer att behöva en ToString() för att skriva ut fordon
    }
}