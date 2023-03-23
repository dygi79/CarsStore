using System.Diagnostics.CodeAnalysis;
using CarsStore;

Console.WriteLine("Witamy w programie CarStore do obsługi magazynu samochodowego");
Console.WriteLine("=============================================================");
Console.WriteLine();

var passengerCar = new PassengerCar("Audi", "osobowy", 1000);
passengerCar.CarAdded += PassengerCar_CarAdded;

void PassengerCar_CarAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ilość sprzedanych samochodów osobowych.");
}

while (true)
{
    Console.WriteLine("Podaj liczbe sprzedaych samochodów osobowych w kolejnych dniach. W celu zakończenia naciśnij litere w.");
    Console.WriteLine("Uwaga, ze względów technicznych nasz magazyn może sprzedać jedynie 25 sztuk samochodów osobowych w ciągu jednego dnia.");
    var input = Console.ReadLine();

    if (input == "w")
    {
        break;
    }
    try
    {
        passengerCar.AddCar(input);
    }

    catch (Exception ex)
    {
       Console.WriteLine($"{ex.Message}");
    }
}
var truckCar = new TruckCar("Audi", "ciężarowy", 8000);
truckCar.CarAdded += TruckCar_CarAdded;
void TruckCar_CarAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ilość sprzedanych samochodów ciężarowych.");
}

while (true)
{
    Console.WriteLine("Podaj liczbe sprzedaych samochodów ciężarowych w kolejnych dniach. W celu zakończenia naciśnij litere w.");
    Console.WriteLine("Uwaga, ze względów technicznych nasz magazyn może sprzedać jedynie 15 sztuk samochodów ciężarowych w ciągu jednego dnia.");
    var input = Console.ReadLine();

    if (input == "w")
    {
        break;
    }
    try
    {
        truckCar.AddCar(input);
    }

    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}
var statisticsPassengerCar = passengerCar.GetStatistics();
var statisticsTruckCar = truckCar.GetStatistics();

float[] totalcars = { statisticsPassengerCar.Sum, statisticsTruckCar.Sum};
float statisticsTotalCar = 0;
for (int i = 0; i < totalcars.Length; i++)
{
    statisticsTotalCar += totalcars[i];
}

Console.WriteLine("========================================================================================================================");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano  samochodów osobowych:{statisticsPassengerCar.Sum} sztuk.");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano samochodów ciężarowych: {statisticsTruckCar.Sum} sztuk.");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano samochodów: {statisticsTotalCar} sztuk.");
Console.WriteLine("========================================================================================================================");
Console.WriteLine($"Najniższa ilość sprzedanych samochodów osobowych w ciągu jednego dnia: {statisticsPassengerCar.Min} sztuk.");
Console.WriteLine("========================================================================================================================");
Console.WriteLine($"Najwyższa ilość sprzedanych samochodów osobowych w ciągu jednego dnia: {statisticsPassengerCar.Max} sztuk.");
Console.WriteLine("========================================================================================================================");
Console.WriteLine($"Średina ilość sprzedanych samochodów osobowych w ciągu jednego dnia: {statisticsPassengerCar.Average} sztuk.");
Console.WriteLine("========================================================================================================================");
Console.WriteLine($"Najniższa ilość sprzedanych samochodów ciężarowych w ciągu jednego dnia: {statisticsTruckCar.Min} sztuk.");
Console.WriteLine("========================================================================================================================");
Console.WriteLine($"Najwyższa ilość sprzedanych samochodów ciężarowych w ciągu jednego dnia: {statisticsTruckCar.Max} sztuk.");
Console.WriteLine("========================================================================================================================");
Console.WriteLine($"Średina ilość sprzedanych samochodów ciężarowych w ciągu jednego dnia: {statisticsTruckCar.Average} sztuk.");
Console.WriteLine("========================================================================================================================");
Console.WriteLine("========================================================================================================================");
