

int daysOff = int.Parse(Console.ReadLine());

int workingDays = 365 - daysOff;

int catSleep = 30000;

int workingDaysPlay = workingDays * 63;
int daysOffPlay = daysOff * 127;

int totalPlay = workingDaysPlay + daysOffPlay;


if (totalPlay <= catSleep)
{
    int leftoverCatSleep = catSleep - totalPlay;
    int hoursConversion = leftoverCatSleep / 60;
    int minutesConversion = leftoverCatSleep % 60;
   
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hoursConversion} hours and {minutesConversion} minutes less for play");
}
else if (totalPlay > catSleep)
{
    int leftoverCatSleep = totalPlay - catSleep;
    int hoursConversion = leftoverCatSleep / 60;
    int minutesConversion = leftoverCatSleep % 60;
    
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hoursConversion} hours and {minutesConversion} minutes more for play");
}