﻿double plosht = double.Parse(Console.ReadLine());
double price = plosht * 7.61;
double discount = price * 0.18;
double finalprice = price - discount;
Console.WriteLine($"The final price is: {finalprice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");