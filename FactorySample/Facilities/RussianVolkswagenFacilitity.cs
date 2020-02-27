using FactorySample.Cars;

namespace FactorySample.Facilities
{
    class RussianVolkswagenFacilitity:VolkswagenFacility
    {
        public override Car CreateCar(string type)
        {
                Car car;
                if (type == "golf")
                {
                    car = new RussianGolf();
                }
                else if (type == "passat")
                {
                    car = new RussianPassat();
                }
                else if (type == "tiguan")
                {
                    car = new RussianTiguan();
                }
                else if (type == "touareg")
                {
                    car = new RussianTouareg();
                }
                else car = new Car();

                return car;


        }
    }
}
