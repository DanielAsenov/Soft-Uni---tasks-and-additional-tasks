



string product = Console.ReadLine();
string city = Console.ReadLine();
double productQuantity = double.Parse(Console.ReadLine());

double price = 0;

if (city == "Sofia")
{
    if (product == "coffee")
    {
        price = 0.50 * productQuantity;
    }
    if (product == "water")
    {
        price = 0.80 * productQuantity;
    }
    if (product == "beer")
    {
        price = 1.20 * productQuantity;
    }
    if (product == "sweets")
    {
        price = 1.45 * productQuantity;
    }
    if (product == "peanuts")
    {
        price = 1.60 * productQuantity;
    }
}
else if (city == "Plovdiv")
{
    if (product == "coffee")
    {
        price = 0.40 * productQuantity;
    }
    if (product == "water")
    {
        price = 0.70 * productQuantity;
    }
    if (product == "beer")
    {
        price = 1.15 * productQuantity;
    }
    if (product == "sweets")
    {
        price = 1.30 * productQuantity;
    }
    if (product == "peanuts")
    {
        price = 1.50 * productQuantity;
    }
}
else if (city == "Varna")
{
    if (product == "coffee")
    {
        price = 0.45 * productQuantity;
    }
    if (product == "water")
    {
        price = 0.70 * productQuantity;
    }
    if (product == "beer")
    {
        price = 1.10 * productQuantity;
    }
    if (product == "sweets")
    {
        price = 1.35 * productQuantity;
    }
    if (product == "peanuts")
    {
        price = 1.55 * productQuantity;
    }
}


Console.WriteLine(price);