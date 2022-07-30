using YourGarage;

// Build a collection of all vehicles that fly
Cessna smallPlane = new Cessna("single", "cessna", "25 feet", "40 gallons", "white", "4");
_747 largePlane = new _747("15", "747", "224 feet", "40,000", "blue", "20");

List<Aircraft> aircraftList = new List<Aircraft>();

aircraftList.Add(smallPlane);
aircraftList.Add(largePlane);

// With a single `foreach`, have each vehicle Fly()
foreach (Aircraft aircraft in aircraftList)
{
    aircraft.Flying();
}

Console.WriteLine();
// Build a collection of all vehicles that operate on roads
ElectricCar elecCar = new ElectricCar("500 volts", "Nissan Leaf", "Green", "4");
Truck truck = new Truck("5x10", "Ford Ranger", "17 gallons", "Red", "3");

List<Car> roadVehicle = new List<Car>();

roadVehicle.Add(elecCar);
roadVehicle.Add(truck);

// With a single `foreach`, have each road vehicle Drive()
foreach (Car car in roadVehicle)
{
    car.Driving();
}

Console.WriteLine();
// Build a collection of all vehicles that operate on water
SailBoat sailboat = new SailBoat("40 feet", "sail boat", "white", "25");
MotorBoat motorboat = new MotorBoat("50 cc", "motor boat", "5 gallons", "yellow", "4");

List<Watercraft> boats = new List<Watercraft>();

boats.Add(sailboat);
boats.Add(motorboat);

// With a single `foreach`, have each water vehicle Drive()
foreach (Watercraft boat in boats)
{
    boat.Driving();
}

Console.ReadLine();
