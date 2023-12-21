double changeAmount = double.Parse(Console.ReadLine());

int coinsCount = 0;

// Превръщаме сумата в цели числа, за да избегнем проблеми с точността на числата с плаваща запетая
int changeInCents = (int)(changeAmount * 100);

while (changeInCents > 0)
{
    if (changeInCents >= 200)
    {
        changeInCents -= 200;
        coinsCount++;
    }
    else if (changeInCents >= 100)
    {
        changeInCents -= 100;
        coinsCount++;
    }
    else if (changeInCents >= 50)
    {
        changeInCents -= 50;
        coinsCount++;
    }
    else if (changeInCents >= 20)
    {
        changeInCents -= 20;
        coinsCount++;
    }
    else if (changeInCents >= 10)
    {
        changeInCents -= 10;
        coinsCount++;
    }
    else if (changeInCents >= 5)
    {
        changeInCents -= 5;
        coinsCount++;
    }
    else if (changeInCents >= 2)
    {
        changeInCents -= 2;
        coinsCount++;
    }
    else if (changeInCents >= 1)
    {
        changeInCents -= 1;
        coinsCount++;
    }
}

Console.WriteLine(coinsCount);