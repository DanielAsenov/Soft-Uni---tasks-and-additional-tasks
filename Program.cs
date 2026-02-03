/*
5
25
41
31
250
6
 

10
10
5
1
100 
12 
26 
17 
37
40
78
 */

int groupCount = int.Parse(Console.ReadLine());

double musalaCount = 0;
double monblanCount = 0;
double kilimanCount = 0;
double k2Count = 0;
double everestCount = 0;


for (int i = 0; i < groupCount; i++)
{
    int peopleCount = int.Parse(Console.ReadLine());

    if (peopleCount <= 5) // Мусала
    {
        musalaCount += peopleCount;
    }
    else if (peopleCount <= 12)
    {
        monblanCount += peopleCount;
    }
    else if (peopleCount <= 25)
    {
        kilimanCount += peopleCount;
    }
    else if (peopleCount <= 40)
    {
        k2Count += peopleCount;
    }
    else if (peopleCount >= 41)
    {
        everestCount += peopleCount;
    }
}

double peopleTotal = musalaCount + monblanCount + kilimanCount + k2Count + everestCount;

Console.WriteLine($"{musalaCount  / peopleTotal * 100:F2}%");
Console.WriteLine($"{monblanCount / peopleTotal * 100:F2}%");
Console.WriteLine($"{kilimanCount / peopleTotal * 100:F2}%");
Console.WriteLine($"{k2Count / peopleTotal * 100:F2}%");
Console.WriteLine($"{everestCount / peopleTotal * 100:F2}%");

