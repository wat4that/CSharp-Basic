// Четене на входни данни
double excursionPrice = double.Parse(Console.ReadLine());
int puzzlesCount = int.Parse(Console.ReadLine());
int dollsCount = int.Parse(Console.ReadLine());
int bearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

// Цени на играчките
double puzzlePrice = 2.60;
double dollPrice = 3.00;
double bearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2.00;

// Изчисляване на общата стойност на поръчката
double totalPrice = (puzzlesCount * puzzlePrice) + (dollsCount * dollPrice) +
                    (bearsCount * bearPrice) + (minionsCount * minionPrice) +
                    (trucksCount * truckPrice);

// Проверка за отстъпка
if ((puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount) >= 50)
{
    totalPrice -= totalPrice * 0.25;
}

// Наем за магазина
totalPrice -= totalPrice * 0.10;

// Проверка дали парите ще стигнат за екскурзия
if (totalPrice >= excursionPrice)
{
    double remainingMoney = totalPrice - excursionPrice;
    Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
}
else
{
    double neededMoney = excursionPrice - totalPrice;
    Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
}
