
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double costCar = 0;
string carType = "";
string carClass = "";



if (budget <= 100)
{
    carClass = "Economy class";
    if (season == "Summer")
    {
        carType = "Cabrio";
        costCar = budget * 0.35;
    }
    else if (season == "Winter")
    {
        carType = "Jeep";
        costCar = budget * 0.65;
    }

}
else if (budget <= 500)
{
    carClass = "Compact class";
    if (season == "Summer")
    {
        carType = "Cabrio";
        costCar = budget * 0.45;
    }
    else if (season == "Winter")
    {
        carType = "Jeep";
        costCar = budget * 0.80;
    }
}
else if (budget > 500)
{
    carClass = "Luxury class";
    carType = "Jeep";
    costCar = budget * 0.90;
}

Console.WriteLine($"{carClass}");
Console.WriteLine($"{carType} - {costCar:F2}");
