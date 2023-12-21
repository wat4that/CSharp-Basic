double budget = double.Parse(Console.ReadLine());
int days =  int.Parse(Console.ReadLine());
double pricePerDay =  double.Parse(Console.ReadLine());
int percentForExtraExpences =  int.Parse(Console.ReadLine());

double moneyLeft = budget - ((pricePerDay * days) + percentForExtraExpences);

if (days >= 7) ;
pricePerDay = pricePerDay / 0.05;
//Console.WriteLine($"Ivanovi will be left with {moneyLeft} leva after vacation.");
