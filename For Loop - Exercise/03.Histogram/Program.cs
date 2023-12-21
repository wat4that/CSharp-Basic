
int n = int.Parse(Console.ReadLine());

int countP1 = 0, countP2 = 0, countP3 = 0, countP4 = 0, countP5 = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        countP1++;
    }
    else if (number >= 200 && number < 400)
    {
        countP2++;
    }
    else if (number >= 400 && number < 600)
    {
        countP3++;
    }
    else if (number >= 600 && number < 800)
    {
        countP4++;
    }
    else
    {
        countP5++;
    }
}

double percentP1 = (double)countP1 / n * 100;
double percentP2 = (double)countP2 / n * 100;
double percentP3 = (double)countP3 / n * 100;
double percentP4 = (double)countP4 / n * 100;
double percentP5 = (double)countP5 / n * 100;

Console.WriteLine($"{percentP1:f2}%");
Console.WriteLine($"{percentP2:f2}%");
Console.WriteLine($"{percentP3:f2}%");
Console.WriteLine($"{percentP4:f2}%");
Console.WriteLine($"{percentP5:f2}%");