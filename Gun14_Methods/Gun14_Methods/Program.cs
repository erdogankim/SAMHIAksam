internal class Program
{
    private static void Main(string[] args)
    {
        //string a = "Ahmet";
        //string buyuk = a.ToUpper();

        //Console.WriteLine(a);
        //Console.WriteLine(buyuk);

        //if (args.Length > 0)
        //{
        //    Console.WriteLine("Parametreli bölüm çalıştı");

        //    int sayi;

        //    bool canTry = int.TryParse(args[0], out sayi);
        //    if (!canTry)
        //    {
        //        Console.WriteLine("Lütfen sayı giriniz ...");
        //    }
        //    else
        //    {
        //        Console.WriteLine(sayi * sayi);
        //    }
        //}

        //Selam();
        //KareYaz(10);

        //CarpimYaz(10, 20);
        //Console.WriteLine("Hello, World!");

        //Console.Write("Kilo değerini giriniz ...:");
        //int kilo = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Boy değerini giriniz ...:");
        //double boy = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Cinsiyet değerini giriniz ...:");
        //string cinsiyet = Console.ReadLine();

        //VKI(kilo, boy, cinsiyet);

        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("İşlem Tamam");

        //double sonuc = MaasHesapla(30, 450);
        //Console.WriteLine(sonuc);

    }

    // Methodlar direk class içerisinde tanımlanırlar
    static void Selam()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Selam");
        }
    }

    static void KareYaz(int sayi)
    {
        Console.WriteLine(sayi * sayi);
    }

    static void CarpimYaz(int sayi1, int sayi2)
    {
        Console.WriteLine(sayi1 * sayi2);
    }

    // parametre olarak, kilo, boy ve cinsiyet değerlerini alan ve 
    // ekrana VKI değerini hesaplayıp yazan methodu yazın ve çağırın. 
    // VKI = (kilo / boy*boy) * CKS  
    // CKS =>   Erkek = 1,2     Kadın = 0,8

    static void VKI(int prmKilo, double prmBoy, string prmCinsiyet)
    {
        double CKS = prmCinsiyet == "E" ? 1.2 : 0.8;
        double VKI = (prmKilo / (prmBoy * prmBoy)) * CKS;
        Console.WriteLine(VKI);
    }

    static double MaasHesapla(int prmCalistigiGunSayisi, double gunlukMaas)
    {
        double aylikMaas = (prmCalistigiGunSayisi * gunlukMaas) * 30;
        return aylikMaas;
    }

    static int Faktoryel(int sayi)
    {
        int faktoryel = 1;

        for (int i = 1; i <= sayi; i++)
        {
            faktoryel *= i;
        }

        return faktoryel;
    }

    static double Combination(int n, int r)
    {
        int nFarktoryel = Faktoryel(n);
        int rFaktoryel = Faktoryel(r);
        int nEksiRFaktoryel = Faktoryel(n-r);

        double c = nFarktoryel / (rFaktoryel * nEksiRFaktoryel);
        return c;

    }
}