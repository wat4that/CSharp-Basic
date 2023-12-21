string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int judgesCount = int.Parse(Console.ReadLine());

double totalPoints = academyPoints;

for (int i = 0; i < judgesCount; i++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());

    int nameLength = judgeName.Length;
    double judgeScore = nameLength * judgePoints / 2.0;

    totalPoints += judgeScore;

    if (totalPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
        return;
    }
}

double neededPoints = 1250.5 - totalPoints;
Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");