
int budget = int.Parse(Console.ReadLine());
string season  = Console.ReadLine();    
int numberOfPeople = int.Parse(Console.ReadLine());


double priceShip = 0;

// price ship

if (season == "Spring")
{
    priceShip = 3000;
}
else if (season == "Summer" ||  season == "Autumn")
{
    priceShip = 4200;
}
else if (season == "Winter")
{
    priceShip = 2600;
}
// number people discounts

if (numberOfPeople <= 6)
{
    priceShip = priceShip * 0.90;
}
else if (numberOfPeople >= 7 &&  numberOfPeople <= 11)
{
    priceShip = priceShip * 0.85;
}
else
{
    priceShip = priceShip * 0.75;
}
// 5% discount

if (numberOfPeople % 2 == 0 && season != "Autumn")
{
    priceShip = priceShip * 0.95;
}


if (budget >= priceShip)
{
    Console.WriteLine($"Yes! You have {budget - priceShip:F2} leva left.");
}
else if (budget < priceShip)
{
    Console.WriteLine($"Not enough money! You need {priceShip - budget:F2} leva.");
}