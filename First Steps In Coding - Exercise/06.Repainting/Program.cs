double nailon = double.Parse(Console.ReadLine());
double boq =  double.Parse(Console.ReadLine());
double razreditel =  double.Parse(Console.ReadLine());
int rabotniChasove =  int.Parse(Console.ReadLine());

double nailonNaMet = (nailon + 2) * 1.50;
double boqNaL = (boq + boq * 0.10) * 14.50;
double razreditelNaL = razreditel * 5.00;
double koshnica = nailonNaMet + boqNaL + razreditelNaL + 0.40;
double maistori = (koshnica * 0.3) * rabotniChasove;
double krainaSuma = koshnica + maistori;

Console.WriteLine(krainaSuma);