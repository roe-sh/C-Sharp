using System;

internal class Car
{
    public string Make { get; set; }
    public int Year { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
    public string Model { get; set; }
    public string PalletNo { get; set; }
    public string Color { get; set; }

    public void DisplayInfo(string make, int year)
    {
        Console.WriteLine($"Car make: {make}, Year: {year}");
    }

    public static void DisplayInfo(string make)
    {
        Console.WriteLine($"Car make: {make}");
    }

    public virtual void Display()
    {
        Console.WriteLine("Welcome Car");
    }
}

class BMW : Car
{
    public override void Display()
    {
        Console.WriteLine("Welcome BMW");
    }
}
