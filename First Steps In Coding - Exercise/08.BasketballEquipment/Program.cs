int taksa = int.Parse(Console.ReadLine());

double kecove = taksa - (taksa * 0.4);
double ekip = kecove - (kecove * 0.2);
double topka = (ekip * 0.25);
double aksesoari = (topka * 0.2);
double obshtaSuma = taksa + kecove + ekip + topka + aksesoari;




Console.WriteLine(obshtaSuma);