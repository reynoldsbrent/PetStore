
namespace Software1ClassExercise1
{
    public interface IProductLogic
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        CatFood GetCatFoodByName(string name);
        DogLeash GetDogLeashByName(string name);
        DryCatFood GetDryCatFoodByName(string name);
        List<string> GetOnlyInStockProducts();
        decimal GetTotalPriceOfInventory();
    }
}