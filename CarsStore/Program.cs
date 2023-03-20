using System.Diagnostics.CodeAnalysis;
using CarsStore;

Console.WriteLine("Witamy w programie CarStore do obsługi magazynu samochodowego");
Console.WriteLine("=============================================================");
Console.WriteLine();

var passengerCarA1 = new PassengerCar("Audi", "A1", 1000);
passengerCarA1.CarAdded += PassengerCarA1_CarAdded;

void PassengerCarA1_CarAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ilość sprzedanych samochodów modelu A1.");
}

var passengerCarA3 = new PassengerCar("Audi", "A3", 2000);
passengerCarA3.CarAdded += PassengerCarA3_CarAdded;
void PassengerCarA3_CarAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ilość sprzedanych samochodów modelu A3.");
}

var passengerCarA4 = new PassengerCar("Audi", "A4", 3000);

passengerCarA4.CarAdded += PassengerCarA4_CarAdded;
void PassengerCarA4_CarAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ilość sprzedanych samochodów modelu A4.");
}


while (true)
{
    Console.WriteLine("Podaj liczbe sprzedaych samochodów A1 w kolejnych dniach. W celu zakończenia naciśnij litere w.");
    Console.WriteLine("Uwaga, ze względów technicznych nasz magazyn może sprzedać jedynie 25 sztuk danego modelu w ciągu jednego dnia.");
    var input = Console.ReadLine();


    if (input == "w")
    {
        break;
    }
    try
    {
        passengerCarA1.AddCar(input);
    }

    catch (Exception ex)
    {
       Console.WriteLine($"{ex.Message}");
    }
    
}

while (true)
{
    Console.WriteLine("Podaj liczbe sprzedaych samochodów A3 w kolejnych dniach. W celu zakończenia naciśnij litere w.");
    Console.WriteLine("Uwaga, ze względów technicznych nasz magazyn może sprzedać jedynie 25 sztuk danego modelu w ciągu jednego dnia.");
    var input = Console.ReadLine();

    if (input == "w")
    {
        break;
    }
    try
    {
        passengerCarA3.AddCar(input);
    }

    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }

}

while (true)
{
    Console.WriteLine("Podaj liczbe sprzedaych samochodów A4 w kolejnych dniach. W celu zakończenia naciśnij litere w.");
    Console.WriteLine("Uwaga, ze względów technicznych nasz magazyn może sprzedać jedynie 25 sztuk danego modelu w ciągu jednego dnia.");
    var input = Console.ReadLine();

    if (input == "w")
    {
        break;
    }
    try
    {
        passengerCarA4.AddCar(input);
    }

    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }

}
var statisticsA1 = passengerCarA1.GetStatistics();
var statisticsA3 = passengerCarA3.GetStatistics();
var statisticsA4 = passengerCarA4.GetStatistics();

float[] totalcars = { statisticsA1.Sum, statisticsA3.Sum, statisticsA4.Sum};
float statisticsTotalCar = 0;
for (int i = 0; i < totalcars.Length; i++)
{
    statisticsTotalCar += totalcars[i];
}

float[] totalprice = { statisticsA1.PriceForModel, statisticsA3.PriceForModel, statisticsA4.PriceForModel};
float statisticsTotalPrice = 0;
for (int i = 0; i < totalprice.Length; i++)
{
    statisticsTotalPrice += totalprice[i];
}


Console.WriteLine("========================================================================================================================");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano  samochodów model A1:  {statisticsA1.Sum} sztuk, za łączną cenę : {statisticsA1.PriceForModel} euro. ");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano  samochodów model A3:  {statisticsA3.Sum} sztuk, za łączną cenę : {statisticsA3.PriceForModel} euro. ");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano  samochodów model A4:  {statisticsA4.Sum} sztuk, za łączną cenę : {statisticsA4.PriceForModel} euro. ");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano samochodów wsztykich modeli: {statisticsTotalCar} sztuk, za łączną cenę {statisticsTotalPrice} euro." );
Console.WriteLine("========================================================================================================================");
//Console.WriteLine($"Średnia cena za jeden egzemplarz to : {statisticAveragePrice:N2} euro.")




