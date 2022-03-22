using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Car : MotoredVehicle
    {

        public bool isOn = false;


        public Car(string Make, string Model, string Year) : base(Make, Model, Year)
        {

        }

        public Car()
        {
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Welcome! We are ready to go");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Vehicle is turned off");
        }

        public void Go(int kilometer)
        {
            if (isOn == false)
            {
                TurnOn();
                if (kilometer * fuelUsedPerKm < fuelTankSize)
                {
                    Console.WriteLine(kilometer + " " + "kilemtr mesafe qet edildi");

                }
                else
                {
                    Console.WriteLine("Low on fuel");
                    TurnOff();
                }
            }
        }
        public override void GetDetailedInfo()
        {
            base.GetDetailedInfo();
            Console.WriteLine("Fuel amount is = " + fuelAmount);
        }
    }
}
