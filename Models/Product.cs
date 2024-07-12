// Task 3 - Create Product.cs
// Correct namespace convention is Project Folder Name (Homework1_Solution) . Models folder name
namespace Homework1_Solution.Models;

public class Product
{
    public string Name {get; set;} = string.Empty; // Resolve null warnings with string.Empty initialization
    public string Description {get; set;} = string.Empty;
    public decimal Price {get; set;}

    // Task 9 - Create ToString() Method
    // Use :C format specifier to print out as currency
    public override string ToString()
    {
        return $"{Name} - {Price:C}";
    }
}