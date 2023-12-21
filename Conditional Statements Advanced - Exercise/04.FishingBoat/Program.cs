int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermenCount = int.Parse(Console.ReadLine());

double boatRent = 0;

switch (season)
{
    case "Spring":
        boatRent = 3000;
        break;
    case "Summer":
    case "Autumn":
        boatRent = 4200;
        break;
    case "Winter":
        boatRent = 2600;
        break;
    default:
        Console.WriteLine("Invalid season");
        return;
}


if (fishermenCount <= 6)
{
    boatRent *= 0.9; // 10% discount
}
else if (fishermenCount <= 11)
{
    boatRent *= 0.85; // 15% discount
}
else
{
    boatRent *= 0.75; // 25% discount
}


if (fishermenCount % 2 == 0 && season != "Autumn")
{
    boatRent *= 0.95; // 5% additional discount
}

double totalCost = budget - boatRent;

if (totalCost >= 0)
{
    Console.WriteLine($"Yes! You have {totalCost:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(totalCost):f2} leva.");
}