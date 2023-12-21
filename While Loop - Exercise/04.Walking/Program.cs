int stepsGoal = 10000;
int totalSteps = 0;

while (totalSteps < stepsGoal)
{
    string input = Console.ReadLine();

    if (input == "Going home")
    {
        int stepsToHome = int.Parse(Console.ReadLine());
        totalSteps += stepsToHome;

        if (totalSteps >= stepsGoal)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
        }
        else
        {
            Console.WriteLine($"{stepsGoal - totalSteps} more steps to reach goal.");
        }

        break;
    }

    int currentSteps = int.Parse(input);
    totalSteps += currentSteps;

    if (totalSteps >= stepsGoal)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
        break;
    }
}