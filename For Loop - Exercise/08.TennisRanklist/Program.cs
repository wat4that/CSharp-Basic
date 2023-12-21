int tournamentsCount = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

int totalPoints = initialPoints;
int totalWins = 0;

for (int i = 0; i < tournamentsCount; i++)
{
    string tournamentResult = Console.ReadLine();

    switch (tournamentResult)
    {
        case "W":
            totalPoints += 2000;
            totalWins++;
            break;
        case "F":
            totalPoints += 1200;
            break;
        case "SF":
            totalPoints += 720;
            break;
    }
}

double averagePoints = ((double)totalPoints) / tournamentsCount;
double winPercentage = (double)totalWins / tournamentsCount * 100;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{winPercentage:F2}%");