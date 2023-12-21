//Input
double budget = double.Parse(Console.ReadLine());
int countVideoCards = int.Parse(Console.ReadLine());
int countCPUs = int.Parse(Console.ReadLine());
int countRAMs = int.Parse(Console.ReadLine());

//Prices
double priceVideoCard = 250;
double percentCPUofVC =  0.35;
double percentRAMofVC = 0.1;

//Calculations
double totalVideoCardsPrice = priceVideoCard * countVideoCards;
double priceCpu = countCPUs * (totalVideoCardsPrice * percentCPUofVC);
double priceRam = countRAMs * (totalVideoCardsPrice * percentRAMofVC);
double totalPrice = totalVideoCardsPrice + priceCpu + priceRam;
double discount = countVideoCards > countCPUs ? 0.15 * totalPrice : 0;
totalPrice -= discount;
double spareMoney = budget - totalPrice;

//Output
if (spareMoney >= 0) 
{
    Console.WriteLine($"You have {spareMoney:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {-spareMoney:f2} leva more!");
}