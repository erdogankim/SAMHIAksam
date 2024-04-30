//Random rastgele = new Random();

//for (int i = 1; i <= 5; i++)
//{
//    int rastgeleSayi = rastgele.Next(1, 100);

//    Console.WriteLine(rastgeleSayi);
//}


// Kolon sayısı dışarıdan girilmek üzere, 
// Girilen kolon sayısı kadar sayısal loto tahminini ekrana yazdırınız 
// her sayısal loto kolonunda 6 tane 1-49 arasında sayı olur. 


Console.Write("Kolon sayısını giriniz ...:");
string strKolon = Console.ReadLine();
int kolon = Convert.ToInt32(strKolon);

Random rnd = new Random();

for (int i = 1; i <= kolon; i++)
{
    for (int j = 1; j <= 6; j++)
    {
        int sayi = rnd.Next(1, 49);
        Console.Write(sayi);
        Console.Write("-");
    }

    Console.WriteLine();
}