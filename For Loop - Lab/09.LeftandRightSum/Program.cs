int n = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

// Четене и сумиране на първите n числа
Console.WriteLine(); //"Въведете първите n числа:"
for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    leftSum += currentNumber;
}

// Четене и сумиране на вторите n числа
Console.WriteLine(); //"Въведете вторите n числа:"
for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    rightSum += currentNumber;
}

// Проверка за равенство и отпечатване на резултата
if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    int diff = Math.Abs(leftSum - rightSum);
    Console.WriteLine($"No, diff = {diff}");
}