
        const double COST_SANDWICH = 4.75;
        const double COST_TOPPING = 0.55;
        const double DISCOUNT_AMOUNT = 0.10;

        // ask for sandwiches, toppings, and discount
        Console.Write("Enter the number of sandwiches: ");
        int numberOfSandwiches = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of toppings: ");
        int numberOfToppings = int.Parse(Console.ReadLine());
        Console.Write("Enter the tip as a decimal (ex: 0.15 for 15%): ");
        double tip = double.Parse(Console.ReadLine());

        // Calculate the total costs
        double totalSandwichCost = COST_SANDWICH * numberOfSandwiches;
        double totalToppingCost = COST_TOPPING * numberOfToppings;
        double baseCost = totalSandwichCost + totalToppingCost;

        // Apply discount and calculate total
        double discountedCost = baseCost * (1 - DISCOUNT_AMOUNT);
        double orderCost = discountedCost + tip;

        // Display the final order cost
        Console.WriteLine($"The total cost of the order is: ${orderCost:F2}"); // This F2 part was found by me on Stackexchange. I cannot take credit for coming up with this by myself.
