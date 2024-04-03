using System;
using System.Text.Json;

namespace Software1ClassExercise1
{
    public class Program
    {
        public static string userInput;
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();

            while(userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    DogLeash leash = new DogLeash();
                    Console.WriteLine("Adding the leash to product inventory.");

                    Console.WriteLine("Enter a description of the leash: ");
                    leash.Description = Console.ReadLine();

                    Console.Write("What is the name of the leash: ");
                    leash.Name = Console.ReadLine();

                    Console.Write("Enter the length of the leash: ");
                    leash.LengthInches = int.Parse(Console.ReadLine());

                    Console.Write("Enter the material of the leash: ");
                    leash.Material = Console.ReadLine();

                    Console.WriteLine("Enter the price of the leash in dollars: ");
                    leash.Price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the amount of leashes in stock: ");
                    leash.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine(JsonSerializer.Serialize(leash));
                }

                Console.WriteLine("Press 1 to add a product.");
                Console.WriteLine("Type 'exit' to quit.");
                userInput = Console.ReadLine();
            }
          
        }
    }
}
