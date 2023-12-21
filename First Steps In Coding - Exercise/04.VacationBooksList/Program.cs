int broistr = int.Parse(Console.ReadLine());  //212
int straniciNaChas = int.Parse(Console.ReadLine());  //20
int dni = int.Parse(Console.ReadLine());  // 2

int obshtochasove = broistr / straniciNaChas;
int chasoveNaDen = obshtochasove / dni;

Console.WriteLine(chasoveNaDen);