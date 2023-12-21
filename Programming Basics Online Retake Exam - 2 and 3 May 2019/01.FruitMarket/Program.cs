double strawberriesPrice = double.Parse(Console.ReadLine());
double bananasInKilograms = double.Parse(Console.ReadLine());
double orangesInKilograms = double.Parse(Console.ReadLine());
double raspberriesInKilograms = double.Parse(Console.ReadLine());
double strawberriesInKilograms = double.Parse(Console.ReadLine());

double totalSum = 0;
totalSum += strawberriesPrice * strawberriesInKilograms;

double raspberriesPrice = strawberriesPrice / 2;
totalSum += raspberriesPrice * raspberriesInKilograms;

double orangesPrice = raspberriesPrice * 0.6;
totalSum += orangesPrice * orangesInKilograms;

double orangePrice = raspberriesPrice * (raspberriesPrice * 0.4);
double bananasPrice = raspberriesPrice * 0.2;
totalSum += bananasPrice * bananasInKilograms;

Console.WriteLine($"{totalSum:f2}");
