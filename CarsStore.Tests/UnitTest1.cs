namespace CarsStore.Tests
{
    public class Tests
    {
        [Test]
        public void TestMedotyMaxMin()
        {
            var passengerCar = new PassengerCar("Audi", "osobowy", 1000);
            passengerCar.AddDailySale(15);
            passengerCar.AddDailySale(8);
            passengerCar.AddDailySale(5);
            passengerCar.AddDailySale(12);

            var statistics = passengerCar.GetStatistics();

            Assert.AreEqual(15, statistics.Max);
            Assert.AreEqual(5, statistics.Min);
        }

        public void TestMetodySumAverage()
        {
            var truckCar = new TruckCar("Audi", "ciêzarowy", 8000);
            truckCar.AddDailySale(15);
            truckCar.AddDailySale(8);
            truckCar.AddDailySale(5);
            truckCar.AddDailySale(12);

            var statistics = truckCar.GetStatistics();

            Assert.AreEqual(40, statistics.Sum);
            Assert.AreEqual(10, statistics.Average);
        }
    }
}