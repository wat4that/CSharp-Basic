int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int totalVolume = width * length * height;

string input = Console.ReadLine();

while (input != "Done")
{
    int boxesCount = int.Parse(input);
    int boxesVolume = 0;

    for (int i = 0; i < boxesCount; i++)
    {
        int boxVolume = int.Parse(Console.ReadLine());
        boxesVolume += boxVolume;
    }

    totalVolume -= boxesVolume;

    if (totalVolume < 0)
    {
        int neededSpace = Math.Abs(totalVolume);
        Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
        return;
    }

    input = Console.ReadLine();
}

Console.WriteLine($"{totalVolume} Cubic meters left.");