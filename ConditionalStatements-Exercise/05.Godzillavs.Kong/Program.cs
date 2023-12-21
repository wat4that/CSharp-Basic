// Четене на входни данни
double budget = double.Parse(Console.ReadLine());
int actorsCount = int.Parse(Console.ReadLine());
double clothingPricePerActor = double.Parse(Console.ReadLine());

// Изчисляване на стойността на декора (10% от бюджета)
double decorPrice = budget * 0.10;

// Изчисляване на стойността на облеклото
double clothingPrice = actorsCount * clothingPricePerActor;

// Проверка за отстъпка за облеклото
if (actorsCount > 150)
{
    clothingPrice -= clothingPrice * 0.10;
}

// Обща сума на разходите за декор и облекло
double totalExpenses = decorPrice + clothingPrice;

// Проверка дали парите са достатъчни за снимането
if (totalExpenses > budget)
{
    double neededMoney = totalExpenses - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
}
else
{
    double remainingMoney = budget - totalExpenses;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");
}