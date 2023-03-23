
namespace CarsStore
{
    public class Statistics
    {
       
        public float Sum { get; set; }

        public int CarsCount { get; set; }

        public float Min { get; set; }

        public float Max { get; set; }


        public float Average
        {
            get
            {
                return this.Sum / this.CarsCount;
            }

        }

        public Statistics() 
        {
            this.Sum = 0;
            this.CarsCount = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        
        }

        public void AddCar(float car)
        {
            this.CarsCount++;
            this.Sum += car;
            this.Max = Math.Max(this.Max, car);
            this.Min = Math.Min(this.Min, car);
        }
        
    }
}
