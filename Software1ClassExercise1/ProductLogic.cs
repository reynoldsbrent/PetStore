using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software1ClassExercise1;

namespace Software1ClassExercise1
{
    public class ProductLogic : IProductLogic
    {
        private List<Product> _products = new List<Product>();
        private Dictionary<string, DogLeash> _dogLeashes = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> _catFoods = new Dictionary<string, CatFood>();
        private Dictionary<string, DryCatFood> _dryCatFoods = new Dictionary<string, DryCatFood>();

        public ProductLogic()
        {
            _products = new List<Product>

            {
                new DogLeash
                {
                    Description = "A rope dog leash made from strong rope.",
                    LengthInches = 60,
                    Material = "Rope",
                    Name = "Rope Dog Leash",
                    Price = 21.00m,
                    Quantity = 0
                },
                new DryCatFood
                {
                    Quantity = 6,
                    Price = 25.59m,
                    Name = "Plain 'Ol Cat Food",
                    Description = "Nothing fancy to find here.  Just the basic stuff your cat needs to live a healthy life",
                    WeightPounds = 10,
                    KittenFood = false
                },
                new CatFood
                {
                    Quantity = 48,
                    Price = 12.99m,
                    Name = "Fancy Cat Food",
                    Description = "Food that isn't only delicious, but made from the finest of all cat food stuff",
                    KittenFood = false
                }
            };
        }

        public List<string> GetOnlyInStockProducts()
        {
            return _products.InStock().Select(x => x.Name).ToList();
        }

        public decimal GetTotalPriceOfInventory()
        {
            return _products.InStock().Select(x => x.Price).Sum();
        }


        public void AddProduct(Product product)
        {
            _products.Add(product);

            if (product is DogLeash)
            {
                DogLeash leash = (DogLeash)product;
                _dogLeashes.Add(leash.Name, leash);
                Console.WriteLine("Dog leash added to inventory.");
            }
            else if (product is DryCatFood)
            {
                DryCatFood dryFood = (DryCatFood)product;
                _dryCatFoods.Add(dryFood.Name, dryFood);
                Console.WriteLine("Dry cat food added to inventory.");
            }
            else if (product is CatFood)
            {
                CatFood food = (CatFood)product;
                _catFoods.Add(food.Name, food);
                Console.WriteLine("Cat food added to inventory.");
            }

        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {

            if (_dogLeashes.ContainsKey(name))
            {
                return _dogLeashes[name];
            }
            else
            {
                Console.WriteLine("The leash name does not exist in the inventory.");
                return null;
            }

        }

        public CatFood GetCatFoodByName(string name)
        {
            if (_catFoods.ContainsKey(name))
            {
                return _catFoods[name];
            }
            else
            {
                Console.WriteLine("The cat food name does not exist in the inventory.");
                return null;
            }
        }

        public DryCatFood GetDryCatFoodByName(string name)
        {
            if (_dryCatFoods.ContainsKey(name))
            {
                return _dryCatFoods[name];
            }
            else
            {
                Console.WriteLine("The dry cat food name does not exist in the inventory.");
                return null;
            }
        }
    }

}
