



using System.Text.Json;

double priceVacation = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int teddyBears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int toyTrucks = int.Parse(Console.ReadLine());

double puzzlesPrice = puzzles * 2.60;
double dollsPrice = dolls * 3;
double teddyBearsPrice = teddyBears * 4.10;
double minionsPrice = minions * 8.20;
double toyTrucksPrice = toyTrucks * 2;

double discount = 0;
double rent = 0;
double moneyLeft = 0;

double priceToys = puzzlesPrice + dollsPrice + teddyBearsPrice + minionsPrice + toyTrucksPrice;

double toysCount = puzzles + dolls + teddyBears + minions + toyTrucks;

if (toysCount >= 50)
{
    discount = priceToys - (priceToys * 0.25);
    rent = discount * 0.10;
    moneyLeft = discount - rent;

}
else if (toysCount < 50)
{
    moneyLeft = priceToys - (priceToys * 0.10);

}

if (moneyLeft >= priceVacation)
{
    Console.WriteLine($"Yes! {moneyLeft - priceVacation:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {priceVacation - moneyLeft:F2} lv needed.");
}
