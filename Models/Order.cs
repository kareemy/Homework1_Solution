// Task 4 - Create Order.cs
namespace Homework1_Solution.Models;

public class Order
{
    public int OrderId {get; set;}
    public string CustomerName {get; set;} = string.Empty;
    // Resolve null warning for list of products by initializing to a new list
    // You can also set this to = default! and initialize it in Program.cs
    public List<Product> Products {get; set;} = new List<Product>();

    // Task 10 - Create ToString() Method
    public override string ToString()
    {
        return $"Order #{OrderId} - {CustomerName}";
    }
}