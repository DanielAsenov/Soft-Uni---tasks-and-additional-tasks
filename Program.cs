
int ChrysanthemumCount = int.Parse(Console.ReadLine());
int rosesCount = int.Parse(Console.ReadLine());
int tulipsCount = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string holiday = Console.ReadLine();


double chrysanthemumPrice = 0;
double rosesPrice = 0;
double tulipsPrice = 0;

if (season == "Spring" || season == "Summer")
{
    chrysanthemumPrice = 2.00;
    rosesPrice = 4.10;
    tulipsPrice = 2.50;
}
else if (season == "Autumn" || season == "Winter")
{
    chrysanthemumPrice = 3.75;
    rosesPrice = 4.50;
    tulipsPrice = 4.15;
}

double totalPrice = (chrysanthemumPrice * ChrysanthemumCount) + (rosesPrice * rosesCount) + (tulipsPrice * tulipsCount);

if (holiday == "Y")
{
    totalPrice = totalPrice * 1.15;
}

if (tulipsCount > 7 && season == "Spring")
{
    totalPrice = totalPrice * 0.95;
}

if (rosesCount >= 10 && season == "Winter")
{
    totalPrice = totalPrice * 0.90;
}

double totalFlowers = ChrysanthemumCount + rosesCount + tulipsCount;

if (totalFlowers > 20)
{
    totalPrice = totalPrice * 0.80;
}


Console.WriteLine($"{totalPrice + 2:F2}");