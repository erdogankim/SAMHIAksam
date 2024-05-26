// Özelliklere sahip olabilin 
// İşlevlere sahip olabilen 
// Olaylara sahip olabilen 
// Oluşan olaylara reaksiyon gösterebilen 
// Programatik yapılardır

internal class Program
{
    private static void Main(string[] args)
    {
        MyClass obj;

        obj = new MyClass(3);

        Kisi ahmet = new Kisi();
        Kisi mehmet = new Kisi();
        DbOperations o1 = new DbOperations("MSSQL");
        DbOperations o2 = new DbOperations("Postgrespl");

        Personel hk = new Personel();
        hk.MaasHesapla(30, 1500);

    }
}


// MatematikFormulleri adında bir class oluşturun. 
// Bu classın içinde FaktryelHesapla adında bir method olsun
// FaktoryelHesapla methoduna parametre olarak gönderilen sayının 
// Faktöryelini hesaplayıp bana geri döndürsün. 

class Personel
{
    public double MaasHesapla(int calistigiGunSayisi, int gunlukMaas)
    {
        return calistigiGunSayisi * gunlukMaas;
    }
}

class MyClass
{
    public MyClass(int sayi)
    {
        
    }
}

class DbOperations
{
    public DbOperations(string type)
    {
        
    }
}

class Kisi
{
    // Oluşturucu methodlar, class ile aynı isme sahip olurlar
    // geri dönüş türleri yoktur. 

    // Nesne yaratılır yaratılmaz ilk çalışan methoddur
    // constructor
    public Kisi()
    {
        Console.WriteLine("Kişi nesnesi yaratıldı");
    }

}

