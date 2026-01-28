

string dayOFweek = Console.ReadLine();

if (dayOFweek == "Monday" || dayOFweek == "Tuesday" || dayOFweek == "Wednesday" || dayOFweek == "Thursday" || dayOFweek == "Friday")
{
    Console.WriteLine("Working day");
}
else if (dayOFweek == "Saturday" || dayOFweek == "Sunday")
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("Error");
}