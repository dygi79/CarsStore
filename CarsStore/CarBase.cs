
namespace CarsStore
{
    public abstract class CarBase : ICarsStore
    {
        public delegate void CarAddedDelegate(object sender, EventArgs args);

        public abstract event CarAddedDelegate CarAdded;
        public CarBase(string carBand, string carModel, float carPrice)
        {
            this.CarBand = carBand;
            this.CarModel = carModel;
            this.CarPrice = carPrice;
        }

        public string CarBand { get; set; }

        public string CarModel { get; set; }

        public float CarPrice { get; set; }

        public abstract void AddCar(float car);

        public abstract void AddCar(string car);

        public abstract void AddCar(double car);

        public abstract void AddCar(int car);

        
        public abstract Statistics GetStatistics();
    }
}
