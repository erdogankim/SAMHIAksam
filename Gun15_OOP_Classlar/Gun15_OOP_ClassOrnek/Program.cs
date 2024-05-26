internal class Program
{
    private static void Main(string[] args)
    {
        MatematikFormulleri mf = new MatematikFormulleri();
        int sonuc = mf.Faktoryel(10);
        Console.WriteLine(sonuc);
    }
}

// n ve r değerlerini parametre olarak alan, 
// hesaplamada Faktoryel methodunu kullanan 
// Kombinasyon methodunu yazınız. 
// kom = n! / r!(n-r)!
class MatematikFormulleri
{
    public int[,] BirimMatrisOlustur(int boyut)
    {
        int[,] matris = new int[boyut, boyut];
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                if (i == j)
                {
                    matris[i, j] = 1;
                }
                else
                {
                    matris[i, j] = 0;
                }
            }
        }

        return matris;
    }
    
    public Program GetPrograam()
    {
        return new Program();
    }

    public int Faktoryel(int sayi)
    {
        int faktoryel = 1;
        for (int i = 1; i <= sayi; i++)
        {
            faktoryel *= i;
        }

        return faktoryel;
    }
    // Boyut parametresi alan BirimMatris adında bir method oluşturun. 
    // Girilen boyut değerinde birim matrisi oluşturup geriye döndürsün. 
    public double Kombinasyon(int n, int r)
    {
        int nFaktoryel = Faktoryel(n);
        int rFaktoryel = Faktoryel(r);
        int nEksiRFaktoryel = Faktoryel(n - r);
        double kombinasyon = nFaktoryel / rFaktoryel * nEksiRFaktoryel;
        return kombinasyon;
    }
}