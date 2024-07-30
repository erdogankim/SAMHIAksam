using Gun19_OOP_Ornek;

internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogr = new Ogrenci();

        Console.Write("TCKN giriniz ...:");
        ogr.TCKN = Console.ReadLine();

        Console.Write("Ad giriniz ...:");
        ogr.Ad = Console.ReadLine();

        Console.Write("Soyad giriniz ...:");
        ogr.Soyad = Console.ReadLine();

        Console.Write("Doğum tarihi giriniz [yyyy-aa-gg] ...:");
        ogr.DogumTarihi = Convert.ToDateTime(Console.ReadLine());

        OgrenciDataOperasyon operasyon = new OgrenciDataOperasyon();
        operasyon.Ekle(ogr);
    }
}