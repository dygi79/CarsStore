namespace CarsStore.Tests
{
    public class Tests
    {
        
        [Test]
        public void TestMedotyMaxMin()
        {
            var passengerCar = new PassengerCar("Audi", "osobowy", 1000);
            passengerCar.AddCar(15);
            passengerCar.AddCar(8);
            passengerCar.AddCar(5);
            passengerCar.AddCar(12);


            var statistics = passengerCar.GetStatistics();

            Assert.AreEqual(15, statistics.Max);
            Assert.AreEqual(5, statistics.Min);
            
        }

        public void TestMetodySumAverage()
        {
            var truckCar = new TruckCar("Audi", "ciêzarowy", 8000);
            truckCar.AddCar(15);
            truckCar.AddCar(8);
            truckCar.AddCar(5);
            truckCar.AddCar(12);


            var statistics = truckCar.GetStatistics();

            Assert.AreEqual(40, statistics.Sum);
            Assert.AreEqual(10, statistics.Average);
        }
    }

}