
// Soru2
// dosyaoperasyon calss ının içerisine
// KlasorGetir adında bir method oluşturun. 
// Method parametre olarak string türünde DosyaYolu alsın. 
// geriye string[] olarak, belirtilen dosya yolundaki bütün dosyaların listesini döndürsün. 

// Tüyo : System.IO kütüphanesinin içinde Directory.GetFiles(yol) şeklinde çalışan 
// bir method bulunmakta. 

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Dosya yolunu giriniz ...:");
        string dosyaYolu = Console.ReadLine();
        DosyaOperasyon operasyon = new DosyaOperasyon();
        string[] klasorler = operasyon.KlasorGetir(dosyaYolu);

        for (int i = 0; i < klasorler.Length; i++)
        {
            Console.WriteLine(klasorler[i]);
        }
        
    }
}

public class DosyaOperasyon
{
    public string[] KlasorGetir(string dosyaYolu)
    {
        string[] klasorler = Directory.GetDirectories(dosyaYolu);
        return klasorler;
    }
}