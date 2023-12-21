int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string feedback = Console.ReadLine();

double pricePerNight = 0;

switch (roomType)
{
    case "room for one person":
        pricePerNight = 18.00;
        break;
    case "apartment":
        pricePerNight = 25.00;
        break;
    case "president apartment":
        pricePerNight = 35.00;
        break;
}

double totalPrice = (days - 1) * pricePerNight; // days - 1, as the first night is not discounted

if (days > 15)
{
    switch (roomType)
    {
        case "room for one person":
            break; // no discount
        case "apartment":
            totalPrice *= 0.50; // 50% discount
            break;
        case "president apartment":
            totalPrice *= 0.80; // 20% discount
            break;
    }
}
else if (days >= 10)
{
    switch (roomType)
    {
        case "room for one person":
            break; // no discount
        case "apartment":
            totalPrice *= 0.65; // 35% discount
            break;
        case "president apartment":
            totalPrice *= 0.85; // 15% discount
            break;
    }
}
else
{
    switch (roomType)
    {
        case "room for one person":
            break; // no discount
        case "apartment":
            totalPrice *= 0.70; // 30% discount
            break;
        case "president apartment":
            totalPrice *= 0.90; // 10% discount
            break;
    }
}

if (feedback == "positive")
{
    totalPrice *= 1.25; // 25% increase
}
else if (feedback == "negative")
{
    totalPrice *= 0.90; // 10% decrease
}

Console.WriteLine($"{totalPrice:f2}");