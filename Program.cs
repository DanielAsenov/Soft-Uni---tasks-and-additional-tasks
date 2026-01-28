/*
 
650
2
175
3
 
1020
1.5
425
4
 
 */


int vineyard = int.Parse(Console.ReadLine());
double grapesPerMetre = double.Parse(Console.ReadLine());
int litresWineNeeded = int.Parse(Console.ReadLine());
int peopleWorking = int.Parse(Console.ReadLine());

double grapesTotal = vineyard * grapesPerMetre;
double wineProduced = (grapesTotal * 0.4) / 2.5;


double wineForWokers = 0;



if (wineProduced >= litresWineNeeded)
{
    wineForWokers = (wineProduced - litresWineNeeded) / peopleWorking;
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
    Console.WriteLine($"{Math.Ceiling(wineProduced - litresWineNeeded)} liters left -> {Math.Ceiling(wineForWokers)} liters per person.");
}
else 
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(litresWineNeeded - wineProduced)} liters wine needed.");
}


