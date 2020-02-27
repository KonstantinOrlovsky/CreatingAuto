using FactorySample.Facilities;
using System;

namespace FactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            VolkswagenFacility RussianFacility = new RussianVolkswagenFacilitity();
            VolkswagenFacility DeutschFacility = new DeutschVolkswagenFacility();
            RussianFacility.GetCar("passat");
            Console.WriteLine();
            RussianFacility.GetCar("golf");
            Console.WriteLine();
            RussianFacility.GetCar("tiguan");
            Console.WriteLine();
            RussianFacility.GetCar("touareg");
            Console.WriteLine("________________________");
            DeutschFacility.GetCar("passat");
            Console.WriteLine();
            DeutschFacility.GetCar("golf");
            Console.WriteLine();
            DeutschFacility.GetCar("tiguan");
            Console.WriteLine();
            DeutschFacility.GetCar("touareg");
            Console.Read();
        }
    }
}
