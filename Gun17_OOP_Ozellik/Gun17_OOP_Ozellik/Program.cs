// See https://aka.ms/new-console-template for more information
// Kişi adında bir nesne oluşturun. 
// Bu nesnenin Kilo, Boy ve Cinsiyet özellikleri olsun. 

// VKI adında başka bir nesne oluşturun. 
// Bu nesnenin hesapla adında bir methodu olsun. 
// Bu method parametre olarak Kişi alsın. 
// Geriye hesaplanmış VKI değerini döndürsün. 

// VKI = (Kilo / (Boy * Boy)) * Katsayı
// Katsayı => Erkekler = 1,3 Kadınlar = 0,8 dir. 


public class Program2
{
    public static void Main(string[] args)
    {
        Kisi k = new Kisi();
        Console.Write("Kilo değerini giriniz ...:");
        k.Kilo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Boy değerini giriniz ...:");
        k.Boy = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cinsiyet giriniz ...:");
        k.Cinsiyet = Console.ReadLine();

        VKI islem = new VKI();
        double islemSonuc = islem.Hesapla(k);
        Console.WriteLine(islemSonuc);
    }
}
