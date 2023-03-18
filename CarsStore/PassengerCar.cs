
using System.Diagnostics;
using System.Drawing;

namespace CarsStore
{
    public class PassengerCar
    {
        
        private List<float> cars = new List<float>();
        float[] priceForCar = new float [0];

        public PassengerCar(string carBand, string carModel, float carPrice)
        {
            this.CarBand = carBand;
            this.CarModel = carModel;
            this.CarPrice = carPrice;
        }

        public string CarBand { get; set;}

        public string CarModel { get; set;}

        public float CarPrice { get; set;}

        
    
        public void AddCar (float car) 
        {
            if (car >=0 && car <= 25)
            {
                this.cars.Add(car);
            }    
            else
            {
                throw new Exception("Podałeś nieprawidłową wartość.");
            }
        }
        public void AddCar(string car)
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
        public void AddCar(double car)
        {
            float carAsFloat = (float)car;
            this.AddCar(carAsFloat);
        }
        public void AddCar(int car)
        {
            float carAsInt = (int)car;
            this.AddCar(carAsInt);
        }

        public Statistics GetStatistics() 
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

