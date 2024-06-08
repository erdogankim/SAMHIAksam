// Bir adet dosyaoperasyon class ı oluşturun. 
// Bu class YeniOlustur adinda bir method barındırsın. 
// bu method parametre olarak "DosyaYolu" adında string değer alsın.
// Geriye herhangi bir değer döndürmesin. 

// Method çağırıldığında, string parametre olarak verilen DosyaYolu değerindeki
// Fiziksel dosya yoluna yeni bir dosya oluştursun. 

// YeniOlustur("c:\Projects\benimyenidosya.txt");
///////////////////////////////////////////////////////////////////////


// Soru2
// dosyaoperasyon calss ının içerisine
// KlasorGetir adında bir method oluşturun. 
// Method parametre olarak string türünde DosyaYolu alsın. 
// geriye strin[] olarak, belirtilen dosya yolundaki bütün dosyaların listesini döndürsün. 

// Tüyo : System.IO kütüphanesinin içinde Directory.GetFiles(yol) şeklinde çalışan 
// bir method bulunmakta. 

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