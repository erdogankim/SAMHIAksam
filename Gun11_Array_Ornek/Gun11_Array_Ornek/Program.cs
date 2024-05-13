// Kolon sayısı dışarıdan girilmek üzere, girilen kolon sayısı kadar sayısal loto
// kuponu oluşturan ve bunu ekranda yazan programı yazınız. 

//Console.Write("Kolon sayısını giriniz ...:");
//int kolonSayisi = Convert.ToInt32(Console.ReadLine());

//int[,] kolonlar = new int[kolonSayisi, 6];
//Random rnd = new Random();

//for (int i = 0; i < kolonSayisi; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        kolonlar[i, j] = rnd.Next(1, 49);
//    }
//}

//for (int i = 0; i < kolonSayisi; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        Console.Write(kolonlar[i,j] + " - ");
//    }
//    Console.WriteLine();
//}

//string myText = "Ahmet,Mehmet,Hasan,Hüseyin,Ali";
//string[] isimler = myText.Split(",");

//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler[i]);
//}


// Dışarıdan girilen 32|45,70|80,65|70 gibi verilen öğrenci yazili1 yazili 2 notlarının
// ortalamalırını hesaplayıp tek bir dizi değişkene atan ve bunu ekranda listeleyen
// programı yazınız. 


//Console.Write("Not textini giriniz ");
//string text = Console.ReadLine();
//string text = "32|45,70|80,65|70,50|80,100|70";

//string[] notlar = text.Split(",");
//double[] ortalamalar = new double[notlar.Length];

//for (int i = 0; i < notlar.Length; i++)
//{
//    string[] yazililar = notlar[i].Split("|");
//    int yazili1 = Convert.ToInt32(yazililar[0]);
//    int yazili2 = Convert.ToInt32(yazililar[1]);

//    ortalamalar[i] = ((yazili1 + yazili2) / 2);

//}

//for (int i = 0; i < ortalamalar.Length; i++)
//{
//    Console.WriteLine(ortalamalar[i]);
//}

// Adım sayısı dışarıdan girilmek üzere, girilen adım sayısı kadar fibonacci
// dizisini ekrana yazdıran programı yazınız. 
// Örnek : AdımSayısı = 8
// Çıktı : 0-1-1-2-3-5-8-13-21

Console.Write("Adım sayısı ...:");
int adim = Convert.ToInt32(Console.ReadLine());

int ilk = 0;
Console.WriteLine(ilk);
int onceki = 1;
Console.WriteLine(onceki);

for (int i = 0; i < adim-2; i++)
{
    int toplam = ilk + onceki;
    ilk = onceki;
    onceki = toplam;
    Console.WriteLine(toplam);

}
