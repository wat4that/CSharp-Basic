// Четене на вход от конзолата
double weight = double.Parse(Console.ReadLine());
string serviceType = Console.ReadLine();
int distance = int.Parse(Console.ReadLine());

double costPerKm;

if (serviceType == "standard")
{
    if (weight < 1)
        costPerKm = 0.03;
    else if (weight <= 10)
        costPerKm = 0.05;
    else if (weight <= 40)
        costPerKm = 0.1;
    else if (weight <= 90)
        costPerKm = 0.15;
    else
        costPerKm = 0.2;
}
else if (serviceType == "express")
{
    if (weight < 1)
        costPerKm = 0.03 * 1.8;
    else if (weight <= 10)
        costPerKm = 0.05 * 1.4;
    else if (weight <= 40)
        costPerKm = 0.1 * 1.05;
    else if (weight <= 90)
        costPerKm = 0.15 * 1.02;
    else
        costPerKm = 0.2 * 1.01;
}
else
{
    Console.WriteLine("Invalid service type");
    return;
}

double totalCost = costPerKm * distance;
totalCost = Math.Round(totalCost, 2);
weight = Math.Round(weight, 3);

Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalCost} lv.");