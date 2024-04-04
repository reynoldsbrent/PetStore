using System;
using System.Text.Json;
namespace Software1ClassExercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductLogic productLogic = new ProductLogic();
            string userInput;
            Console.WriteLine("Press 1 to add a product. Dog Leash, Cat Food, or Dry Cat Food.");
            Console.WriteLine("Press 2 to find a product by name.");
            Console.WriteLine("Type 'exit' to quit.");
            userInput = Console.ReadLine();

            while(!userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                // Adding a product.
                if (userInput == "1")
                {
                    Console.WriteLine("What type of product would you like to add?");
                    string productType = Console.ReadLine();

                    if(productType == "Dog Leash")
                    {
                        DogLeash leash = new DogLeash();
                        Console.WriteLine("Adding the leash to product inventory.");

                        Console.WriteLine("Enter a description of the leash: ");
                        leash.Description = Console.ReadLine();

                        Console.WriteLine("What is the name of the leash: ");
                        leash.Name = Console.ReadLine();



                        Console.WriteLine("Enter the length of the leash in inches: ");
                        try
                        {
                            leash.LengthInches = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid input for leash length. Please enter a number.");
                            leash.LengthInches = int.Parse(Console.ReadLine());
                        }

                        Console.Write("Enter the material of the leash: ");
                        leash.Material = Console.ReadLine();

                        try
                        {
                            Console.WriteLine("Enter the price of the leash in dollars: $ ");
                            leash.Price = decimal.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid input for leash price. Please enter a number.");
                            leash.Price = decimal.Parse(Console.ReadLine());
                        }
                        try
                        {
                            Console.WriteLine("Enter the amount of leashes in stock: ");
                            leash.Quantity = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input for leash quantity. Please enter a number.");
                            leash.Quantity = int.Parse(Console.ReadLine());
                        }


                        productLogic.AddProduct(leash);

                        Console.WriteLine("Dog Leash added to inventory.");
                    }
                    else if(productType == "Cat Food")
                    {
                        CatFood catFood = new CatFood();
                        Console.WriteLine("Adding the cat food to product inventory.");

                        Console.WriteLine("Enter a description of the cat food: ");
                        catFood.Description = Console.ReadLine();

                        Console.WriteLine("What is the name of the cat food: ");
                        catFood.Name = Console.ReadLine();

                        Console.WriteLine("Is this kitten food? (yes/no): ");
                        try
                        {
                            string kittenFood = Console.ReadLine();
                            if (kittenFood.Equals("yes", StringComparison.OrdinalIgnoreCase))
                            {
                                catFood.KittenFood = true;
                            }
                            else if (kittenFood.Equals("no", StringComparison.OrdinalIgnoreCase))
                            {
                                catFood.KittenFood = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                                kittenFood = Console.ReadLine();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                            string kittenFood = Console.ReadLine();
                        }

                        try
                        {
                            Console.WriteLine("Enter the price of the cat food in dollars: $ ");
                            catFood.Price = decimal.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid input for cat food price. Please enter a number.");
                            catFood.Price = decimal.Parse(Console.ReadLine());
                        }
                        try
                        {
                            Console.WriteLine("Enter the amount of this cat food in stock: ");
                            catFood.Quantity = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input for cat food quantity. Please enter a number.");
                            catFood.Quantity = int.Parse(Console.ReadLine());
                        }


                        productLogic.AddProduct(catFood);

                        Console.WriteLine("Cat food added to inventory.");
                    }
                    else if(productType == "Dry Cat Food")
                    {
                        DryCatFood dryCatFood = new DryCatFood();
                        Console.WriteLine("Adding the dry cat food to product inventory.");

                        Console.WriteLine("Enter a description of the dry cat food: ");
                        dryCatFood.Description = Console.ReadLine();

                        Console.WriteLine("What is the name of the dry cat food: ");
                        dryCatFood.Name = Console.ReadLine();

                        Console.WriteLine("Is this kitten food? (yes/no): ");
                        try
                        {
                            string kittenFood = Console.ReadLine();
                            if (kittenFood.Equals("yes", StringComparison.OrdinalIgnoreCase))
                            {
                                dryCatFood.KittenFood = true;
                            }
                            else if (kittenFood.Equals("no", StringComparison.OrdinalIgnoreCase))
                            {
                                dryCatFood.KittenFood = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                                kittenFood = Console.ReadLine();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                            string kittenFood = Console.ReadLine();
                        }
                        try
                        {
                            Console.WriteLine("Enter the weight of the dry cat food in pounds: ");
                            dryCatFood.WeightPounds = double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input for dry cat food weight. Please enter a number.");
                            dryCatFood.WeightPounds = double.Parse(Console.ReadLine());
                        }

                        try
                        {
                            Console.WriteLine("Enter the price of the dry cat food in dollars: $ ");
                            dryCatFood.Price = decimal.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid input for dry cat food price. Please enter a number.");
                            dryCatFood.Price = decimal.Parse(Console.ReadLine());
                        }
                        try
                        {
                            Console.WriteLine("Enter the amount of this dry cat food in stock: ");
                            dryCatFood.Quantity = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input for dry cat food quantity. Please enter a number.");
                            dryCatFood.Quantity = int.Parse(Console.ReadLine());
                        }


                        productLogic.AddProduct(dryCatFood);

                        Console.WriteLine("Dry cat food added to inventory.");
                    }
                    
                }
                // Find a product by name.
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter the type of product you would like to search for: Dog Leash, Cat Food, or Dry Cat Food.");
                    string product = Console.ReadLine();
                    Console.WriteLine("Enter the name of the product you want to find: ");
                    string productName = Console.ReadLine();
                    if(product == "Dog Leash")
                    {
                        DogLeash leash = productLogic.GetDogLeashByName(productName);
                        if(leash != null)
                        {
                            Console.WriteLine("Leash found: ");
                            Console.WriteLine(JsonSerializer.Serialize(leash));
                        }
                    }
                    else if(product == "Cat Food")
                    {
                        CatFood food = productLogic.GetCatFoodByName(productName);
                        if (food != null)
                        {
                            Console.WriteLine("Cat food found: ");
                            Console.WriteLine(JsonSerializer.Serialize(food));
                        }
                    }
                    else if(product == "Dry Cat Food")
                    {
                        DryCatFood dryFood = productLogic.GetDryCatFoodByName(productName);
                        if (dryFood != null)
                        {
                            Console.WriteLine("Dry cat food found: ");
                            Console.WriteLine(JsonSerializer.Serialize(dryFood));
                        }
                    }
                }

                Console.WriteLine("Press 1 to add a product. Dog Leash, Cat Food, or Dry Cat Food.");
                Console.WriteLine("Press 2 to find a product by name.");
                Console.WriteLine("Type 'exit' to quit.");
                userInput = Console.ReadLine();
            }
         
        }
    }
}
