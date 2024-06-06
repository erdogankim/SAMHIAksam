// Bir adet dosyaoperasyon class ı oluşturun. 
// Bu class YeniOlustur adinda bir method barındırsın. 
// bu method parametre olarak "DosyaYolu" adında string değer alsın.
// Geriye herhangi bir değer döndürmesin. 

// Method çağırıldığında, string parametre olarak verilen DosyaYolu değerindeki
// Fiziksel dosya yoluna yeni bir dosya oluştursun. 

// YeniOlustur("c:\Projects\benimyenidosya.txt");


using Gun18_OOP_Ornek;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen oluşturmak istediğiniz dosya yolu ve adını giriniz ...:");
        string yol = Console.ReadLine();

        DosyaOperasyon operasyon = new DosyaOperasyon();
        operasyon.YeniOlustur(yol);

        Console.WriteLine("Dosya oluşturuldu.");
    }
}