int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

// Добавяне на 15 минути
minutes += 15;

// Проверка за преминаване на час
if (minutes >= 60)
{
    hours++;
    minutes -= 60;
}

// Проверка за преминаване на денонощие
if (hours >= 24)
{
    hours -= 24;
}

Console.WriteLine($"{hours}:{minutes:d2}");