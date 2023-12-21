int startingpoints = int.Parse(Console.ReadLine());
double bonus = 0.0;

if (startingpoints <= 100)
{
    bonus = 5;
}
else if (startingpoints >= 1000)
{
    bonus = startingpoints * 0.1;
}
else 
{
    bonus = startingpoints * 0.2;
}
 if (startingpoints % 2 == 0)
{
    bonus = bonus + 1;
}
 else if (startingpoints % 10 == 5)
{
    bonus += 2;
}

    Console.WriteLine(bonus);
Console.WriteLine(bonus + startingpoints);