double himikali = double.Parse(Console.ReadLine());
double markeri = double.Parse(Console.ReadLine());
double preparat =  double.Parse(Console.ReadLine());
int otstapka = int.Parse(Console.ReadLine());

double brHim = himikali * 5.80;
double brMarkeri = markeri * 7.20;
double brPreparat = preparat * 1.20;
double obshtaSuma = brHim + brMarkeri + brPreparat;
double krainaCena = obshtaSuma - (obshtaSuma * otstapka) / 100;

Console.WriteLine($"{krainaCena} lv.");
