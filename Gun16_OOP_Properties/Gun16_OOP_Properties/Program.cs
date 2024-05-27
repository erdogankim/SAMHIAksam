internal class Program
{
    private static void Main(string[] args)
    {
        Telephone samsung = new Telephone();
        samsung.ScreenSize = 5.3;

        Personel isci = new Personel();
        isci.Ad = "Ahmet";
        isci.Soyad = "Demir";
        isci.TCKN = "1111111111";

        Personel mudur = new Personel();
        mudur.Ad = "Mehmet";
        mudur.Soyad = "Demir";
        mudur.TCKN = "2222222222";
    }
}

// Abone adında bir class oluşturun. 
// Bu class ın içerisinde, sonindex, ilkindex ve kullanım yeri özellikleri olsun. 

public class Telephone
{
    public double ScreenSize { get; set; }

    public Telephone()
    {

    }

    ~Telephone()
    {

    }

}

public class Personel
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string TCKN { get; set; }
}