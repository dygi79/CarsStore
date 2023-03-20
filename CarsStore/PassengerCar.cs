
using System.Diagnostics;
using System.Drawing;
using static CarsStore.CarBase;

namespace CarsStore
{
    public class PassengerCar : CarBase
    {
        public override event CarAddedDelegate CarAdded;

        private List<float> cars = new List<float>();
        
        public PassengerCar(string carBand, string carModel, float carPrice)
            : base(carBand, carModel, carPrice)
        {

        } 

        public override void AddCar (float car) 
        {
            if (car >=0 && car <= 25)
            {
                this.cars.Add(car);
                if (CarAdded != null)
                {
                    CarAdded(this, new EventArgs());
                }
            }    
            else
            {
                throw new Exception("Podałeś nieprawidłową wartość.");
            }
        }
        public override void AddCar(string car)
        {
            if (float.TryParse(car, out float result))
            {
                this.AddCar(result);
            }
            else if (char.TryParse(car, out char letter))
            {
                this.AddCar(letter);
            }
            else
            {
                throw new Exception("Podaj prawidłową wartość.");

            }
        }
        public override void AddCar(double car)
        {
            float carAsFloat = (float)car;
            this.AddCar(carAsFloat);
        }
        public override void AddCar(int car)
        {
            float carAsInt = (int)car;
            this.AddCar(carAsInt);
        }

        public override Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Sum = 0;
            
            

            foreach (var car in this.cars)
            if (car >= 0)
                {
                    statistics.Sum += car;
                    statistics.PriceForModel = statistics.Sum * CarPrice;

                }
            return statistics;
        }

    }

}

