using Infrastructure;
using Models;

namespace EFCoreTutorial.CA;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("EF Core Tutorial");
        
        // new context (db session)
        using ContosoPetsContext context = new ContosoPetsContext();
        
        // reading info from db
        var productsGreaterThanOrEqualTo5Pound = context.Products
            .Where(p => p.Price >= 5.00m)
            .OrderBy(p => p.Name);

        foreach (var p in productsGreaterThanOrEqualTo5Pound)
        {
            Console.WriteLine($"Id : {p.Id}");
            Console.WriteLine($"Name : {p.Name}");
            Console.WriteLine($"Price : {p.Price}");
            Console.WriteLine(new String('-', 20));
        }
    }
}