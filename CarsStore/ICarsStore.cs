using CarsStore;
using static CarsStore.CarBase;

namespace CarsStore
{
    public interface ICarsStore
    {
        public string CarBand { get; }

        public string CarModel { get; }

        public float CarPrice { get; }

        void AddDailySale(int car);

        void AddDailySale(string car);

        event CarAddedDelegate CarAdded;
        Statistics GetStatistics();
    }
}
