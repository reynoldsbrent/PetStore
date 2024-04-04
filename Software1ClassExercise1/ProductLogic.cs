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
            }
            else if (product is CatFood)
            {
                CatFood food = (CatFood)product;
                _catFoods.Add(food.Name, food);
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
    }
}
