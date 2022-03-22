using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.make = "Toyota";
            car1.model = "Toyota";
            car1.year = "2001";

            Motocycle moto1 = new Motocycle();
            moto1.horsePower = 1000;

            Boat boat1 = new Boat();
            boat1.fuelTankSize = 150;
        }
    }
}
