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
    Console.WriteLine("Dodano nową ilość sprzedanych samochodów modelu A1.");
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

Console.WriteLine("===================================================================================================================");
Console.WriteLine("===================================================================================================================");

Console.WriteLine($"Łącznie sprzedano  samochodów model A1:  {statisticsA1.Sum}, za łączną cene : {statisticsA1.PriceForModel} euro. ");
Console.WriteLine("====================================================================================================================");
Console.WriteLine($"Łącznie sprzedano  samochodów model A3:  {statisticsA3.Sum}, za łączną cene : {statisticsA3.PriceForModel} euro. ");
Console.WriteLine("===================================================================================================================");
Console.WriteLine($"Łącznie sprzedano  samochodów model A4:  {statisticsA4.Sum}, za łączną cene : {statisticsA4.PriceForModel} euro. ");