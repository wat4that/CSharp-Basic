int groupsCount = int.Parse(Console.ReadLine());
int totalClimbers = 0;

int musalaClimbers = 0;
int montBlancClimbers = 0;
int kilimanjaroClimbers = 0;
int k2Climbers = 0;
int everestClimbers = 0;

for (int i = 0; i < groupsCount; i++)
{
    int groupSize = int.Parse(Console.ReadLine());
    totalClimbers += groupSize;

    if (groupSize <= 5)
    {
        musalaClimbers += groupSize;
    }
    else if (groupSize <= 12)
    {
        montBlancClimbers += groupSize;
    }
    else if (groupSize <= 25)
    {
        kilimanjaroClimbers += groupSize;
    }
    else if (groupSize <= 40)
    {
        k2Climbers += groupSize;
    }
    else
    {
        everestClimbers += groupSize;
    }
}

double musalaPercentage = (double)musalaClimbers / totalClimbers * 100;
double montBlancPercentage = (double)montBlancClimbers / totalClimbers * 100;
double kilimanjaroPercentage = (double)kilimanjaroClimbers / totalClimbers * 100;
double k2Percentage = (double)k2Climbers / totalClimbers * 100;
double everestPercentage = (double)everestClimbers / totalClimbers * 100;

Console.WriteLine($"{musalaPercentage:f2}%");
Console.WriteLine($"{montBlancPercentage:f2}%");
Console.WriteLine($"{kilimanjaroPercentage:f2}%");
Console.WriteLine($"{k2Percentage:f2}%");
Console.WriteLine($"{everestPercentage:f2}%");