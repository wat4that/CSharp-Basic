﻿int n = int.Parse(Console.ReadLine());

int minNumber = int.MaxValue;
int maxNumber = int.MinValue;

for (int i = 1; i <= n; i++) 
{
    int currentNumber = int.Parse((Console.ReadLine()));

	if (currentNumber < minNumber)
	{
		minNumber = currentNumber;
	}
	if (currentNumber > maxNumber)
	{
		maxNumber = currentNumber;
	}
}

Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minNumber}");