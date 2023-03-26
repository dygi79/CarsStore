using static CarsStore.CarBase;
namespace CarsStore
{
    public class PassengerCar : CarBase
    {
        private const string fileName = "passengercars.txt";
        public override event CarAddedDelegate CarAdded;

        public PassengerCar(string carBand, string carModel, float carPrice)
            : base(carBand, carModel, carPrice)
        {

        }

        public override void AddDailySale(int car)
        {
            if (car >= 0 && car <= 25)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(car);
                }

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

        public override void AddDailySale(string car)
        {
            if (int.TryParse(car, out int result))
            {
                this.AddDailySale(result);
            }
            else if (char.TryParse(car, out char letter))
            {
                this.AddDailySale(letter);
            }
            else
            {
                throw new Exception("Podaj prawidłową wartość.");

            }
        }

        public override Statistics GetStatistics()
        {
            var carFromFile = this.ReadCarsFromFile();
            var result = this.CountStatistics(carFromFile);
            return result;
        }

        private List<float> ReadCarsFromFile()
        {
            var cars = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var numer = float.Parse(line);
                        cars.Add(numer);
                        line = reader.ReadLine();
                    }
                }
            }
            return cars;
        }

        private Statistics CountStatistics(List<float> cars)
        {
            var statistics = new Statistics();

            foreach (var car in cars)

            {
                statistics.AddDailySale(car);
            }
            return statistics;
        }
    }
}


