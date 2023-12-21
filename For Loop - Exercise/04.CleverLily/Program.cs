int age = int.Parse(Console.ReadLine());

double washingMachinePrice = double.Parse(Console.ReadLine());

int toyPrice = int.Parse(Console.ReadLine());

int toys = 0;
double money = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 1)
    {
        toys++;
    }
    else
    {
        money += (i / 2) * 10 - 1; 
    }
}

money += toys * toyPrice;
if (money >= washingMachinePrice)
{
    double remainingMoney = money - washingMachinePrice;
    Console.WriteLine($"Yes! {remainingMoney:f2}");
}
else
{
    double neededMoney = washingMachinePrice - money;
    Console.WriteLine($"No! {neededMoney:f2}");
}