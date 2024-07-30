using Gun19_Oop_Ornek2;

internal class Program
{
    private static void Main(string[] args)
    {
        Category category = new Category();
        Console.Write("Kategori adını giriniz ...:");
        category.CategoryName = Console.ReadLine();

        Console.Write("Açıklmayı giriniz ...:");
        category.Description = Console.ReadLine();

        CategoryRepository repository = new CategoryRepository();
        repository.Add(category);
        Console.WriteLine("Db ye eklendi");
    }
}