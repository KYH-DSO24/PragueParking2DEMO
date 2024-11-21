namespace PragueParking2
{
    public class ParkingSpot
    {
        public int Size { get; set; }
        public int Height { get; set; } // Behövs på VG-nivå
        public int AvailableSize { get; set; }
        public int SpotNumber { get; set; }
        public List<Vehicle> ParkedVehicles { get; set; }
        public ParkingSpot(int spotNumber)
        {
            Size = 4; //TODO: skall komma från konfigfil
            SpotNumber = spotNumber;
            AvailableSize = Size;
            Height = 2; //TODO: skall komma från konfigfil
            ParkedVehicles = new List<Vehicle>();
        }
        
        public void AddVehicle(Vehicle vehicle)
        {
            ParkedVehicles.Add(vehicle);
            AvailableSize -= vehicle.Size;
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            ParkedVehicles?.Remove(vehicle);
            AvailableSize += vehicle.Size;
        }
        public bool IsThereRoomForVehicle(Vehicle vehicle)
        {
            return (vehicle.Size <= AvailableSize);
        }
        public bool CheckForRegNumber(string regNumber)
        {
            var result = ParkedVehicles.Any(v => v.RegNumber == regNumber);
            return result;

            //foreach (var vehicle in ParkedVehicles)
            //{
            //    if (vehicle.RegNumber == regNumber)
            //        return true;
            //}
            //return false;
        }
    }
}