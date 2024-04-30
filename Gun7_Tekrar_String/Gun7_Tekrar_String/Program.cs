// string : Kelime Katarı : Alfanumerik ifadeler stringdir
// 500 : numeric
// "500" : alfanumeric
//string strDegisken = "Deneme";
// char[] (char array)

//string myValue = "A" + "B";

// n=5 olmak üzere Ekrana aşağıdaki deseni çizen programı yazınız. 
// *
// **
// ***
// ****
// *****

//Console.Write("N değerini giriniz ...:");
//string strN = Console.ReadLine();
//int n = Convert.ToInt32(strN);

//for (int i = 1; i <= n; i++)
//{
//	for (int j = 1; j <= i; j++)
//	{
//		Console.Write("*");
//	}
//	Console.WriteLine();
//}


// n=5 olmak üzere Ekrana aşağıdaki deseni çizen programı yazınız. 
// *
// **
// ***
// ****
// *****
// *****
// ****
// ***
// **
// *


//Console.Write("N değerini giriniz ...:");
//string strN = Console.ReadLine();
//int n = Convert.ToInt32(strN);

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//for (int i = n; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

// Piglatin bir kelime oyunudur. Belirlenmiş bir kelimenin son harfi 
// alınıp en başa konulup yeni bir kelime üreterek oynanır. 
// Harfleri başa ala ala ilk yazılan kelimeye gelindiğinde oyun biter 

// ANTALYA kelimesinin piglatin oyun dömükü aşağıdaki gibidir. 

// ANTALYA
// AANTALY
// YAANTAL
// LYAANTA
// ALYAANT
// TALYAAN
// NTALYAA
// ANTALYA

// Soru: Kelime dışarıdan girildiğinde bu şekilde piglatin döngüsünü 
// gösteren programı yazınız. 

string kelime = "ANTALYA";
Console.WriteLine(kelime);

string subKelime = kelime.Substring(0, 4);
Console.WriteLine(subKelime);

string subKelime2 = kelime.Substring(3);
Console.WriteLine(subKelime2);

int karakterSayisi = kelime.Length;
Console.WriteLine(karakterSayisi);