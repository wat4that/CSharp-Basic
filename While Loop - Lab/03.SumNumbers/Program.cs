int number = int.Parse(Console.ReadLine());
int sum = 0;

while (true)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber;

    if (sum >= number)
    {
        Console.WriteLine(sum);
        break;
    }
}