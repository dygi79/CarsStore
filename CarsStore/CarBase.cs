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

        public string CarBand { get; private set; }

        public string CarModel { get; private set; }

        public float CarPrice { get; private set; }

        public abstract void AddDailySale(int car);

        public abstract void AddDailySale(string car);

        public abstract Statistics GetStatistics();
    }
}
