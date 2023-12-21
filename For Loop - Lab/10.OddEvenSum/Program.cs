Console.Write("Въведете брой числа (n): ");
int n = int.Parse(Console.ReadLine());

int sumEven = 0;
int sumOdd = 0;

// Четене и сумиране на числата на четни и нечетни позиции
for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        // Четна позиция
        sumEven += currentNumber;
    }
    else
    {
        // Нечетна позиция
        sumOdd += currentNumber;
    }
}

// Проверка за равенство и отпечатване на резултата
if (sumEven == sumOdd)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sumEven}");
}
else
{
    int diff = Math.Abs(sumEven - sumOdd);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}