using Pet_store_1;
using System.ComponentModel;
using System.Text.Json;

namespace Pet_store_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var productLogic = new ProductLogic();
            var product = new Product();

            Console.WriteLine("Hello, World!");
            string userInput;
            do
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do");
                Console.WriteLine("Add a product");
                Console.WriteLine("0.Exit");
                userInput = Console.ReadLine()!;
                if (userInput == null)
                {
                    userInput = "";
                    continue;
                }

                if (userInput == "1" || userInput.ToLower() == "a")
                {
                    CatFood catFood = new CatFood()
                    {
                        Name = "Catfood",
                        Price = 20.20m,
                        Description = " Yummy food for cats",
                        Quantity = 10,
                        WeightPounds = 5.6,
                        KittenFood = false,
                    };

                    productLogic.AddProduct(product);
                    Console.WriteLine("Yay! The product is added");
                }
                else if (userInput == "2" || userInput.ToLower() == "b")
                {
                    DogLeash dogLeash = new DogLeash()
                    {
                        Name = "DogLeash",
                        Price = 18.50m,
                        Description = "Leash for your fluffy friend!",
                        Quantity = 1,
                        LenghtInches = 54,
                        Material = "Leather"
                    };

                    productLogic.AddProduct(product);
                    Console.WriteLine("Yay! The product is added");
                }
            } while (userInput == null );
        }
    }
}
