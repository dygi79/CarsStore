using CarsStore;
using static CarsStore.CarBase;

namespace CarsStore
{
    public interface ICarsStore
    {
        public string CarBand { get; }

        public string CarModel { get; }

        public float CarPrice { get; }

        void AddCar(float car);

        void AddCar(string car);

        void AddCar(double car);

        void AddCar(int car);

        event CarAddedDelegate CarAdded;
        Statistics GetStatistics();
    }
}
