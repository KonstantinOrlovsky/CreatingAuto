using FactorySample.Cars;

namespace FactorySample.Facilities
{
    class DeutschVolkswagenFacility : VolkswagenFacility
    {
        public override Car CreateCar(string type)
        {
            Car car;
            if (type == "golf")
            {
                car = new DeutschGolf();
            }
            else if (type == "passat")
            {
                car = new DeutschPassat();
            }
            else if (type == "tiguan")
            {
                car = new DeutschTiguan();
            }
            else if (type == "touareg")
            {
                car = new DeutschTouareg();
            }
            else car = new Car();

            return car;
        }
    }
}
