using CarsStore;
using static CarsStore.CarBase;

namespace CarsStore
{
    public interface ICarsStore
    {
        public string CarBand { get; set; }

        public string CarModel { get; set; }

        public float CarPrice { get; set; }

        void AddCar(float car);

        void AddCar(string car);

        void AddCar(double car);

        void AddCar(int point);

      
        event CarAddedDelegate CarAdded;
        Statistics GetStatistics();
    }
}
