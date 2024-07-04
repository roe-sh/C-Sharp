using System;


namespace OOP_tasks6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BMW bMW = new BMW();
            //bMW.Display();
            Car carbmw = new BMW();
            carbmw.Display();


            Car.DisplayInfo("GGR");
            BMW.DisplayInfo("GGR");

            Car car = new Car();
            car.Display();

        }
    }
}
