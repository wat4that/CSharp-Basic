int pile = int.Parse(Console.ReadLine());
int riba  = int.Parse(Console.ReadLine());
int veg = int.Parse(Console.ReadLine());

double cenaPile = pile * 10.35;
double cenaRba = riba * 12.40;
double cenaVeg = veg * 8.15;
double obshto = cenaPile + cenaRba + cenaVeg;
double desert = obshto * 0.2;
double final = obshto + desert + 2.50;

Console.WriteLine(final);