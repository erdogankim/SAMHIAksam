using Gun19_OOP_Ornek3;

public class Program
{
    private static void Main(string[] args)
    {
        ProductRepository repo = new ProductRepository();
        var products = repo.GetAllProducts();

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(products[i].ProductName);
            Console.WriteLine(products[i].UnitPrice);
            Console.WriteLine("------------------------");
        }
    }
}