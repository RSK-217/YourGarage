using YourGarage;

//// Build a collection of all vehicles that fly
Cessna smallPlane = new Cessna();
smallPlane.Type = "Cessna";
smallPlane.Wingspan = "25 feet";
smallPlane.Crew = "1";
smallPlane.Occupancy = "4";
smallPlane.Color = "Red";

_747 largePlane = new _747();
largePlane.Wingspan = "225 feet";
largePlane.Type = "747";
largePlane.Crew = "20";
largePlane.Occupancy = "300";
largePlane.Color = "Blue";
largePlane.FuelOrBatteryCapacity = "40,000 gallons";

List<IVehicle> aircraftList = new List<IVehicle>();

aircraftList.Add(smallPlane);
aircraftList.Add(largePlane);

//// With a single `foreach`, have each vehicle Fly()
foreach (IVehicle aircraft in aircraftList)
{
    aircraft.Operating();
}

Console.WriteLine();
//// Build a collection of all vehicles that operate on roads
ElectricCar nissanLeaf = new ElectricCar();
nissanLeaf.Type = "Nissan Leaf";
nissanLeaf.FuelOrBatteryCapacity = "500 Volts";
nissanLeaf.Occupancy = "5";
nissanLeaf.Color = "Silver";

Truck fordRanger = new Truck();
fordRanger.Type = "Ford Ranger";
fordRanger.FuelOrBatteryCapacity = "17 gallons";
fordRanger.Occupancy = "3";
fordRanger.Color = "Green";
fordRanger.Bedsize = "5 x 10";
     
List<IVehicle> roadVehicle = new List<IVehicle>();

roadVehicle.Add(nissanLeaf);
roadVehicle.Add(fordRanger);

//// With a single `foreach`, have each road vehicle Drive()
foreach (IVehicle vehicle in roadVehicle)
{
    vehicle.Operating();
}

Console.WriteLine();
// Build a collection of all vehicles that operate on water
SailBoat sailboat = new SailBoat();
    sailboat.Mastsize = "40";
    sailboat.Occupancy = "25";
    sailboat.Color = "White";
    sailboat.Type = "sail boat";

MotorBoat motorboat = new MotorBoat();
motorboat.Type = "motor boat";
motorboat.Engine = "50 cc";
motorboat.FuelOrBatteryCapacity = "10 gallons";
motorboat.Occupancy = "6";
motorboat.Color = "yellow";

List<IVehicle> boats = new List<IVehicle>();

boats.Add(sailboat);
boats.Add(motorboat);

// With a single `foreach`, have each water vehicle Drive()
foreach (IVehicle boat in boats)
{
    boat.Operating();
}

Console.ReadLine();
