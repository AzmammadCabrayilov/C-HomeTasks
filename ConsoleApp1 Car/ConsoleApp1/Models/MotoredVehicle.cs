using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class MotoredVehicle
    {
        public string make;
        public string model;
        public string year;
        public int fuelAmount;
        public int fuelUsedPerKm;
        public string color;
        public int passengerCount;
        public int horsePower;
        public int fuelTankSize;
        public int transmission;
        public string fuelType;


        public MotoredVehicle()
        {

        }

        public MotoredVehicle(string Make,string Model, string Year)
        {
            make = Make;
            model = Model;
            year = Year;
        }

        public void GetInfo()
        {
            Console.WriteLine("Axtaris neticesi bunlardir");
        }

        public virtual void GetDetailedInfo()
        {
            Console.WriteLine("Etrafli axtaris:");
        }




        
    }
}
