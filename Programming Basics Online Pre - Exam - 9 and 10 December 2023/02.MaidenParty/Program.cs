double priceParty = double.Parse(Console.ReadLine());
int countMessages = int.Parse(Console.ReadLine());
int countRoses = int.Parse(Console.ReadLine());
int countKeychains = int.Parse(Console.ReadLine());
int countCaricatures = int.Parse(Console.ReadLine());
int countSurprises = int.Parse(Console.ReadLine());

double priceMessages = countMessages * 0.60;
double priceRoses = countRoses * 7.20;
double priceKeychains = countKeychains * 3.60;
double priceCaricatures = countCaricatures * 18.20;
double priceSurprises = countSurprises * 22.0;

double totalPrice = priceMessages + priceRoses + priceKeychains + priceCaricatures + priceSurprises;

if (countMessages + countRoses + countKeychains + countCaricatures + countSurprises >= 25)
{
    totalPrice *= 0.65;
}

double totalAfterExpenses = totalPrice * 0.90; // Отнемаме 10% за хостинг

if (totalAfterExpenses >= priceParty)
{
    double leftMoney = totalAfterExpenses - priceParty;
    Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
}
else
{
    double neededMoney = priceParty - totalAfterExpenses;
    Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
}