const int baseCampAltitude = 5364;
const int everestAltitude = 8848;
const int maxDaysClimbing = 5;

int totalDays = 0;
int totalAltitude = baseCampAltitude;

while (true)
{
    string willRest = Console.ReadLine();

    switch (willRest)
    {
        case "END":
            if (totalAltitude >= everestAltitude)
            {
                Console.WriteLine($"Goal reached for {totalDays} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(totalAltitude);
            }
            return;

        case "Yes":
            totalDays++;
            break;

        case "No":
            break;

        default:
            Console.WriteLine("Invalid command!");
            return;
    }

    int metersClimbed;
    if (!int.TryParse(Console.ReadLine(), out metersClimbed))
    {
        Console.WriteLine("Invalid input for meters climbed!");
        return;
    }

    totalAltitude += metersClimbed;

    if (totalAltitude >= everestAltitude)
    {
        Console.WriteLine($"Goal reached for {totalDays} days!");
        return;
    }

    if (totalDays >= maxDaysClimbing)
    {
        Console.WriteLine("Failed!");
        Console.WriteLine(totalAltitude);
        return;
    }
}