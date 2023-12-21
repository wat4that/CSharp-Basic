
        string flowerType = Console.ReadLine();
        int flowerCount = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double flowerPrice = 0;

        switch (flowerType)
        {
            case "Roses":
                flowerPrice = 5;
                if (flowerCount > 80)
                {
                    flowerPrice *= 0.9; // 10% discount
                }
                break;
            case "Dahlias":
                flowerPrice = 3.80;
                if (flowerCount > 90)
                {
                    flowerPrice *= 0.85; // 15% discount
                }
                break;
            case "Tulips":
                flowerPrice = 2.80;
                if (flowerCount > 80)
                {
                    flowerPrice *= 0.85; // 15% discount
                }
                break;
            case "Narcissus":
                flowerPrice = 3;
                if (flowerCount < 120)
                {
                    flowerPrice *= 1.15; // 15% increase
                }
                break;
            case "Gladiolus":
                flowerPrice = 2.50;
                if (flowerCount < 80)
                {
                    flowerPrice *= 1.2; // 20% increase
                }
                break;
            default:
                Console.WriteLine("Invalid flower type");
                return;
        }

        double totalCost = flowerCount * flowerPrice;

        if (budget >= totalCost)
        {
            double leftMoney = budget - totalCost;
            Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {leftMoney:f2} leva left.");
        }
        else
        {
            double neededMoney = totalCost - budget;
            Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
        }

