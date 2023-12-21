int days = int.Parse(Console.ReadLine());
double totalLiters = 0;
double totalDegrees = 0;

for (int day = 1; day <= days; day++)
{
    double liters = double.Parse(Console.ReadLine());
    double degrees = double.Parse(Console.ReadLine());

    totalLiters += liters;
    totalDegrees += liters * degrees;
}

double averageDegrees = totalDegrees / totalLiters;

Console.WriteLine($"Liter: {totalLiters:F2}");
Console.WriteLine($"Degrees: {averageDegrees:F2}");

if (averageDegrees < 38)
{
    Console.WriteLine("Not good, you should baking!");
}
else if (averageDegrees >= 38 && averageDegrees <= 42)
{
    Console.WriteLine("Super!");
}
else
{
    Console.WriteLine("Dilution with distilled water!");
}