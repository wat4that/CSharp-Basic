﻿double accountBalance = 0;
string input =  Console.ReadLine();


while (input != "NoMoreMoney")
{
    double currentAmount = double.Parse(input);

    if (currentAmount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    accountBalance += currentAmount;
    Console.WriteLine($"Increase: {currentAmount:f2}");

    input = Console.ReadLine();
}
Console.WriteLine($"Total: {accountBalance:f2}");