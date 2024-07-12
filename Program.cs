// Task 5 - Bring in Homework1_Solution.Models with using keyword
using Homework1_Solution.Models;

// Task 6 - Create FOUR product objects
Product NeuralImplant = new Product { Name = "MindSync", Description = "Neural Implant Device", Price = 1995.99M };
Product AIAssistant = new Product { Name = "Seraphine", Description = "AI Assistant", Price = 200.00M };
Product DeathRay = new Product { Name = "SoulSear", Description = "Military Grade Death Ray", Price = 4300000000M };
Product Mouse = new Product { Name = "PhantomClaw", Description = " High Quality Gaming Mouse", Price = 99.95M };

// Task 7 - Create THREE orders
Order OrderOne = new Order { OrderId = 1, CustomerName = "US Government" };
OrderOne.Products.Add(DeathRay);
OrderOne.Products.Add(NeuralImplant);
OrderOne.Products.Add(AIAssistant);

Order OrderTwo = new Order {
    OrderId = 2,
    CustomerName = "North Korea",
    Products = new List<Product> {NeuralImplant, DeathRay, Mouse}
};

Order OrderThree = new Order {
    OrderId = 3,
    CustomerName = "Kareem Dana",
    Products = new List<Product> {AIAssistant, Mouse}
};

// Task 8 - Create a list of orders
List<Order> ListOfOrders = new List<Order> {OrderOne, OrderTwo, OrderThree};

// Task 11 - Loop
foreach (Order o in ListOfOrders)
{
    decimal totalPrice = 0.00M;
    Console.WriteLine(o); // Print out object. This invokes ToString()
    foreach (Product p in o.Products)
    {
        Console.WriteLine($"\t{p}");
        totalPrice += p.Price;
    }
    Console.WriteLine($"Order Total: {totalPrice:C}");
    Console.WriteLine();
}
