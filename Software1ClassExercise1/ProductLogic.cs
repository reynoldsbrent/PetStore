using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1ClassExercise1
{
    public class ProductLogic
    {
        private List<Product> _products = new List<Product>();
        private Dictionary<string, DogLeash> _dogLeashes = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> _catFoods = new Dictionary<string, CatFood>();
        private Dictionary<string, DryCatFood> _dryCatFoods = new Dictionary<string, DryCatFood>();

        public ProductLogic() { 
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

            if(product is DogLeash)
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

        public List<Product> GetAllProducts() {
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
