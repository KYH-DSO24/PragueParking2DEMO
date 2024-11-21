using PragueParking2;

// Test av switch on type:
var car = new Car("CAR001");
var mc = new Mc("MC001");

TellMeTheType(car);
TellMeTheType(mc);

Console.ReadKey();

void TellMeTheType(object x)
{
    switch (x)
    {
        case Car c:
            Console.WriteLine("It's a car with registration number {0}", c.RegNumber);
            break;
        case Mc mc:
            Console.WriteLine("It's a MC with registration number {0}", mc.RegNumber);
            break;
        default:
            break;
    }
}