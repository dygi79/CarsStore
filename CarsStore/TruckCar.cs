﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarsStore.CarBase;

namespace CarsStore
{
    public class TruckCar : CarBase

        {
            private const string fileName = "truckcars.txt";
            public override event CarAddedDelegate CarAdded;

            
            public TruckCar(string carBand, string carModel, float carPrice)
                : base(carBand, carModel, carPrice)
            {

            }
            public override void AddCar(float car)
            {
                if (car >= 0 && car <= 15)
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
            public override void AddCar(string car)
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
            public override void AddCar(double car)
            {
                float carAsFloat = (float)car;
                this.AddCar(carAsFloat);
            }
            public override void AddCar(int car)
            {
                float carAsInt = (int)car;
                this.AddCar(carAsInt);
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
                statistics.AddCar(car);
              
            }
            return statistics;

        }
        }
    }





