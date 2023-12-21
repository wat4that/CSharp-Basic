//input
double deposit = double.Parse(Console.ReadLine());
int srok  = int.Parse(Console.ReadLine());
double lihva = double.Parse(Console.ReadLine()) / 100;

//calculations
double natrypanalihva = deposit * lihva;
double lihvanaMes = natrypanalihva / 12;
double suma = deposit + (srok * lihvanaMes);

//output
Console.WriteLine(suma);
