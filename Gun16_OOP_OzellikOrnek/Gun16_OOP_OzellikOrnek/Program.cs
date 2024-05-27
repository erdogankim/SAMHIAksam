
// Abone adında bir class oluşturun. 
// Bu class ın içerisinde, sonindex, ilkindex ve kullanım yeri özellikleri olsun.

// AboneIslem adında bir class oluşturun. 
// içinde FaturaHesapla adında bir method olsun. 
// Bu method geriye double olarak hesaplanmış faturayı döndürsün. 
// Parametre olarak da Abone alsın. 
// Dışarıdan girilen değerlerle
// KullanımYeri => Mesken = 1.13, Umumi = 0.7

internal class Program
{
    private static void Main(string[] args)
    {
        Abone abone = new Abone();
        Console.Write("Son index değerini giriniz ...:");
        abone.SonIndex = Convert.ToInt32(Console.ReadLine());

        Console.Write("İlk index değerini giriniz ...:");
        abone.IlkIndex = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kullanım yerini giriniz ...:");
        abone.KullanimYeri= Console.ReadLine();

        AboneIslem aboneIslem = new AboneIslem();
        double faturaTutari = aboneIslem.FaturaHesapla(abone);
        Console.WriteLine(faturaTutari);

    }
}

public class Abone
{
    public int SonIndex { get; set; }
    public int IlkIndex { get; set; }
    public string KullanimYeri { get; set; }
}

public class AboneIslem
{
    public double FaturaHesapla(Abone a)
    {
        double birimFiyat = 0;
        if (a.KullanimYeri == "Mesken")
        {
            birimFiyat = 1.13;
        }
        else
        {
            birimFiyat = 0.7;
        }

        double kullanilanSuMiktari = a.SonIndex - a.IlkIndex;
        double toplam = birimFiyat * kullanilanSuMiktari;
        return toplam;
    }
}