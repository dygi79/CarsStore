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

var statisticsPassengerCar = passengerCar.GetStatistics();

/*float[] totalcars = { statisticsA1.Sum, statisticsA3.Sum, statisticsA4.Sum};
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

var statisticsAveragePrice = statisticsTotalPrice / statisticsTotalCar; */

Console.WriteLine("========================================================================================================================");
Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano  samochodów osobowych:{statisticsPassengerCar.Sum} sztuk, za łączną cenę : {statisticsPassengerCar.PriceForModel} euro. ");
Console.WriteLine("=======================================================================================================================");


/*Console.WriteLine("=======================================================================================================================");
Console.WriteLine($"Łącznie sprzedano samochodów wsztykich modeli: {statisticsTotalCar} sztuk, za łączną cenę {statisticsTotalPrice} euro." );
Console.WriteLine("========================================================================================================================");
Console.WriteLine($"Średnia cena za jeden egzemplarz to : {statisticsAveragePrice:N2} euro.");*/




