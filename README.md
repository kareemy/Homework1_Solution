## Your Name: Homework 1 Solution

# CIDM 3312 Homework 1 - C# Review
The objective of this homework is to review C# classes, objects, methods, and lists which are vital components to this course. This homework also introduces the concept of relationships between classes. You will create a class that contains a list of objects from another class.

**ThoughtTronix** is a multi-billion dollar multinational AI conglomorate with customers ranging from individual end-users to huge military contracts. ThoughtTronix recently hired you as an intern. Your first task is to write a small, console app that displays some of their major products and recent orders. Create a C# app that models ThoughtTronix's products and orders. Your app should meet the following requirements:

1. Start by cloning this assignment repository into VS Code.
2. Create a new C# console app using the `dotnet new console` command.
3. Model ThoughtTronix's products with a `Product.cs` class in the Models/ folder. The `Product` class should contain product name, description, and price properties.
4. Model orders with an `Order.cs` class in the Models/ folder. The `Order` class should contain an OrderId, CustomerName, and **list of products** properties.
     - This is a **challenging task**. We have not used a list within a class before. Reach out on slack for help.
5. Resolve all null warnings. Both `Product.cs` and `Order.cs` should be in the same namespace following the correct naming convention. Don't forget the `using` keyword in `Program.cs` to ensure the classes are accessible.
6. In `Program.cs`, create FOUR products based on this table:
   | Product Name | Product Description       | Price          |
   | ------------ | ------------------------- | -------------- |
   | MindSync     | Neural Implant Device     | $1,995.99      |
   | Seraphine    | AI Assistant              | $200.00        |
   | SoulSear     | Military Grade Death Ray  | $4,300,000,000 |
   | PhantomClaw  | High Quality Gaming Mouse | $99.95         |
7. Create THREE orders based on this table:
   | OrderId | CustomerName  | Products Ordered                |
   | ------- | ------------- | ------------------------------- |
   | 1       | US Government | SoulSear, MindSync, Seraphine   |
   | 2       | North Korea   | MindSync, SoulSear, PhantonClaw |
   | 3       | Kareem Dana   | Seraphine, PhantomClaw          |
   - This is a  **challenging task**. You have to add the corresponding product objects to the list of products for each order.
8. Add all three orders to a list of orders. 
9. In `Product.cs` add a `ToString()` method that returns a product in this format `MindSync - $1,995.99`.
10. In `Order.cs` add a `ToString()` method that returns an order in this format `Order #1 - US Government`.
11. Back in `Program.cs`, loop through your list of orders and display all orders and products utilizing the `ToString()` methods. Within the loop, add the total cost of each order and display that as well. See the following output for an example:
```
Order #1 - US Government
        SoulSear - $4,300,000,000.00
        MindSync - $1,995.99        
        Seraphine - $200.00
Order Total: $4,300,002,195.99      

Order #2 - North Korea
        MindSync - $1,995.99        
        SoulSear - $4,300,000,000.00
        PhantomClaw - $99.95        
Order Total: $4,300,002,095.94      

Order #3 - Kareem Dana
        Seraphine - $200.00
        PhantomClaw - $99.95        
Order Total: $299.95
```
12. Please remember to comment your code. Add small, one line comments explaining each task. Add more detailed comments ot highlight new things you learned and challenges you encountered and how you overcame them.

## Submit your assignment
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Edit `README.md` and put your name at the top.
3. Push your changes to GitHub:
    - Click the source control icon in VS Code
    - Type in a commit message
    - Click the checkbox icon to commit. (Click yes on the message box to stage your commit)
    - Click the 3 dots icon (...) for more actions and click Push.
4. Or you can push your changes to GitHub using the Terminal:
    ```
    git add -A
    git commit -m "Your commit message"
    git push
    git status
    ```
4. Verify that your changes are on GitHub.
6. Congratulations! Your assignment is complete.