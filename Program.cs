/*

900
2
1
3


920.45
3
1
1




*/





double budget = double.Parse(Console.ReadLine());
int gpuCount = int.Parse(Console.ReadLine());
int cpuCount = int.Parse(Console.ReadLine());
int memoryCount = int.Parse(Console.ReadLine());

double gpuPrice = gpuCount * 250;
double cpuPrice = cpuCount * (gpuPrice * 0.35);
double memoryPrice = memoryCount * (gpuPrice * 0.10);
double totalPrice = gpuPrice + cpuPrice + memoryPrice;

if (gpuCount > cpuCount)
{
    totalPrice = totalPrice - (totalPrice * 0.15);
}


if (totalPrice <= budget)
{
    Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
}


else if (totalPrice > budget)
{
    Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
}