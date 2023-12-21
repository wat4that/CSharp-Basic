int dal = int.Parse(Console.ReadLine());
int shir =  int.Parse(Console.ReadLine());
int vis = int.Parse(Console.ReadLine());
double procent = double.Parse(Console.ReadLine());

double obem = dal * shir * vis;
double litri = obem * 0.001;
double drob = procent / 100;
double FinalLitri = litri * (1 - drob);

Console.WriteLine(FinalLitri);