double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine().ToLower();

string destination = "";
string vacationType = "";
double spendAmount = 0;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        vacationType = "Camp";
        spendAmount = budget * 0.3;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        spendAmount = budget * 0.7;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        vacationType = "Camp";
        spendAmount = budget * 0.4;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        spendAmount = budget * 0.8;
    }
}
else
{
    destination = "Europe";
    vacationType = "Hotel";
    spendAmount = budget * 0.9;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{vacationType} - {spendAmount:f2}");