
// Dışarıdan girilen 5 farklı sayıyı, 5 elemanlı bir dizi değişkene sırası ile atayan 
// ve bu değerleri ekranda listeleyen programı yazınız.
//int[] arrSayilar = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.Write(i+1);
//    Console.Write(". eleman değerini giriniz ...:");
//    string strSayi = Console.ReadLine();
//    int sayi = Convert.ToInt32(strSayi);
//    arrSayilar[i] = sayi;
//}


//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(arrSayilar[i]);
//}

// 10 elemanlı sayısal bir dizi değişkenin, tüm elemanlarını 1-100 arası rastgele 
// sayılarla dolduran ve bu sayıları ekranda listeleyen programı yazınız.

//int[] arrSayilar = new int[10];

//Random rnd = new Random();

//for (int i = 0; i < 10; i++)
//{
//    arrSayilar[i] = rnd.Next(1,100);
//    Console.WriteLine(arrSayilar[i]);
//}

// 10 elemanlı rastgele sayılarla doldurulmuş iki farklı dizi değişken oluşturun. 
// daha sonra bu iki farklı dizi değişkenin elemanlarının sırası ile ortalamasını alıp 
// 3. 10 elemanlı dizi değişkenin içerisine yazdırın. 


//int[] arr1 = new int[10];
//int[] arr2 = new int[10];
//int[] arrOrt = new int[10];

//Random rnd = new Random();

//for (int i = 0; i < 10; i++)
//{
//    arr1[i] = rnd.Next(1,100);
//    arr2[i] = rnd.Next(1, 100);

//    arrOrt[i] = (arr1[i] + arr2[i]) / 2;
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(arrOrt[i]);
//}


// Sınıf mevcudu dışarıdan girilmek üzere, 
// 1. yazılıları ayrı, ikinci yazılıları ayrı ortalamalırını da ayrı dizi değişkenlerde
// tutmak üzere, yine dışarıdan girilen 1. ve 2. yazılı notlarının ortalamalarını hesaplayan
// ve ekrana yazdıran programı yazınız. 



Console.Write("Sınıf mevcudunu giriniz ...:");
int mevcut = Convert.ToInt32(Console.ReadLine());

int[] arrYazili1 = new int[mevcut];
int[] arrYazili2 = new int[mevcut];
int[] arrOrtalama = new int[mevcut];

for (int i = 0; i < mevcut; i++)
{
    Console.Write((i + 1) + ". öğrenci için yazılı 1 notunu giriniz ...:");
    arrYazili1[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write((i + 1) + ". öğrenci için yazılı 2 notunu giriniz ...:");
    arrYazili2[i] = Convert.ToInt32(Console.ReadLine());

    arrOrtalama[i] = (arrYazili1[i] + arrYazili2[i]) / 2;
}

for (int i = 0; i < mevcut; i++)
{
    Console.WriteLine((i + 1) + ". öğrenci için ortalama notu...:" + arrOrtalama[i]);
}
