int numberOfPeople = int.Parse(Console.ReadLine());
int numberOfNights = int.Parse(Console.ReadLine());
int cardsForTransport = int.Parse(Console.ReadLine());
int ticketsCount = int.Parse(Console.ReadLine());

double moneyForNights = numberOfNights * 20;
double moneyForCarts = cardsForTransport * 1.6;
double moneyForMuseum = ticketsCount * 6;
double moneyPerPerson = moneyForNights + moneyForCarts + moneyForMuseum;
double priceForGroup = moneyPerPerson * numberOfPeople;
double totalCost = priceForGroup + (priceForGroup * 0.25);

Console.WriteLine($"{totalCost:F2}");
