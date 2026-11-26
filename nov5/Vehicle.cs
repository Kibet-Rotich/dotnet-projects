using System.Runtime.CompilerServices;

class Vehicle
{
    public string make;
    public string model;
    public int year;

    public void StartEngine()
    {
        Console.WriteLine("Engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped");

    }
}

class Car : Vehicle
{
    public int NumberOfDoors;
    
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

class Motorcycle : Vehicle
{
    public string type;
    public void Ride()
    {
        Console.WriteLine("Riding a motorcyle");

    }
}
//
class Truck : Vehicle
{
    public int loadCapacity;
    public void LoadCargo(){
        Console.WriteLine("loading cargo");
    }
}