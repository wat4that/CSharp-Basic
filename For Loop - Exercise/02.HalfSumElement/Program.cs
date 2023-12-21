int n = int.Parse(Console.ReadLine());

int sum = 0;
int maxElement = int.MinValue;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    sum += number;

    if (number > maxElement)
    {
        maxElement = number;
    }
}

int diff = Math.Abs(maxElement - (sum - maxElement));

if (maxElement == (sum - maxElement))
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + maxElement);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}