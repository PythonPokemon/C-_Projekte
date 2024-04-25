using System;

// Basisklasse für Fahrzeuge
class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Mileage { get; set; }

    public Vehicle(string brand, string model, int year, double mileage)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Mileage = mileage;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km");
    }
}

// Unterklassen für Auto und Lastwagen
class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, string model, int year, double mileage, int numberOfDoors)
        : base(brand, model, year, mileage)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of doors: {NumberOfDoors}");
    }
}

class Truck : Vehicle
{
    public double LoadCapacity { get; set; }

    public Truck(string brand, string model, int year, double mileage, double loadCapacity)
        : base(brand, model, year, mileage)
    {
        LoadCapacity = loadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Load capacity: {LoadCapacity} tons");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Erstellen von Fahrzeugobjekten und Anzeigen ihrer Informationen
        Vehicle vehicle1 = new Car("Toyota", "Corolla", 2018, 50000, 4);
        Vehicle vehicle2 = new Truck("Ford", "F-150", 2015, 80000, 2.5);

        Console.WriteLine("Vehicle 1 Information:");
        vehicle1.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Vehicle 2 Information:");
        vehicle2.DisplayInfo();
    }
}
