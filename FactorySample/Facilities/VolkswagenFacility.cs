using FactorySample.Cars;


namespace FactorySample.Facilities
{
   abstract class VolkswagenFacility
    {
       
        public Car GetCar(string type)
        {
            Car car=CreateCar(type);
            
            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();
            return car;

        }
        public abstract Car CreateCar(string type); 
    }
}
