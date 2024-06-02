using System;

class Program
{
    static void Main(string[] args)
    {

        //Initialize new customer1 product list
        //Nest and set new products for customer1    
        List<Product> customer1Products = new()
        {
            new("Floss", "FL3490", 1.50, 3),
            new("Magnets", "MG36273", 5.35, 2),
            new("Dress", "DR38473", 19.99, 1)
        };


        //Nest, Initialze, and set new customer1 order, new customer1 and new customer1 address
        //Parameters: customer1 name, customer1 address and customer1 product list
        Order customer1Order = new(new Customer("Sally Jones",  new Address("1212 North Street", "Raleigh", "North Carolina", "USA")), customer1Products);

        //Display CustomerName
        Console.WriteLine();
        Console.WriteLine($"Customer 1: {customer1Order.GetCustomerOrderName()}");
        Console.WriteLine();


        //Display and call customer1Order GetShippingLabel, GetPackingLabel, and CalculateOrderTotalCost methods
        Console.WriteLine($"Shipping Label\n\n{customer1Order.GetShippingLabel()}");

        Console.WriteLine($"Packing Label\n\n{customer1Order.GetPackingLabel()}");

        Console.WriteLine($"{customer1Order.GetCustomerOrderName()} Order Total: ${customer1Order.CalculateOrderTotalCost()}");

       
        //Initialize new customer2 product list
        //Nest and set new products for customer2    
        List<Product> customer2Products = new()
        {
            new("Sheets", "SH3849372", 25.99, 1),
            new("Mattress Protector", "MP873621", 15.99, 1),
            new("Toilet Paper", "TP6293733", 9.99, 4)
        };


        //Nest, Initialze, and set new customer2 order, new customer2 and new customer1 address
        //Parameters: customer1 name, customer2 address and customer2 product list
        Order customer2Order = new(new Customer("James Clifton",  new Address("2161 Yonge Street", "Toronto", "Ontario", "Canada")), customer2Products);

        //Display CustomerName
        Console.WriteLine();
        Console.WriteLine($"Customer 2: {customer2Order.GetCustomerOrderName()}");
        Console.WriteLine();

        
        //Display and call customer2Order GetShippingLabel, GetPackingLabel, and CalculateOrderTotalCost methods
        Console.WriteLine($"Shipping Label\n\n{customer2Order.GetShippingLabel()}");

        Console.WriteLine($"Packing Label\n\n{customer2Order.GetPackingLabel()}");

         Console.WriteLine($"{customer2Order.GetCustomerOrderName()} Order Total: ${customer2Order.CalculateOrderTotalCost()}");
    }
}



        //Nesting initialization and setting of new order, new customer, and new product list
        // Order customer1Order = new(
        //     new Customer(
        //         "Sally Jones",
        //          new Address("1212 North St", "Raleigh", "North Carolina", "USA")
        //     ), 
        //     new List<Product>()
        //     {
        //         new("floss", "FL3490", 1.50, 3),
        //         new("magnets", "MG36273", 5.35, 2),
        //         new("dress", "CL38473", 19.99, 1)
        //     }
        // );