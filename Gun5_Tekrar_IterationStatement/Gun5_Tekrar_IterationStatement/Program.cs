// 3 basamaklı çift sayıların listesini ekranda yazdıran programı yazınız. ?

//for (int i = 100; i <= 999; i++)
//{
//	if (i % 2 == 0)
//	{
//		Console.WriteLine(i);
//	}
//}

//for (int i = 100; i <= 999; i+=2)
//{
//	Console.WriteLine(i);
//}

// 4 basamaklı ve 15 e tam bölünebilen sayıların listesi
//for (int i = 1000; i <= 9999; i++)
//{
//	if (i % 15 == 0)
//	{
//		Console.WriteLine(i);
//	}
//}

// tersten yazıldığında aynı sonucu veren sayılara Polidron adı verilir. 
// 3 basamaklı polidron sayıları ekrana yazdıran programı yazınız. 

//for (int i = 100; i <= 999; i++)
//{
//	int abc = i;

//	int a = abc / 100;
//	int bc = abc - (a * 100);
//	int b = bc / 10;
//	int c = bc - (b * 10);

//	int cba = (c * 100) + (b * 10) + a;

//	if (abc == cba)
//	{
//		Console.WriteLine(abc);
//	} 
//}
// 4 basamaklı polidron sayıları ekrana yazdıran programı yazınız. 

//for (int i = 1000; i <= 9999; i++)
//{
//	int abcd = i;
//	int a = abcd / 1000;
//	int bcd = abcd - (a * 1000);
//	int b = bcd / 100;
//	int cd = bcd - (b * 100);
//	int c = cd / 10;
//	int d = cd - (c * 10);

//	int dcba = d * 1000 + c * 100 + b * 10 + a;

//	if (abcd == dcba)
//	{
//		Console.WriteLine(abcd);
//	}
//}


// Dışarıdan girilen iki sayının çarpımını ekrana yazdıran programı yazınız. 
// (çarpma işlemi kullanmadan)

// 5 * 3 
// 5 + 5 + 5
// 3 + 3 + 3 + 3 + 3

//Console.Write("Birinci sayıyı giriniz ..:");
//string strSayi1 = Console.ReadLine();
//int sayi1 = Convert.ToInt32(strSayi1);

//Console.Write("İkinci sayıyı giriniz ..:");
//string strSayi2 = Console.ReadLine();
//int sayi2 = Convert.ToInt32(strSayi2);

//int toplam = 0;
//for (int i = 1; i <= sayi1; i++)
//{
//    toplam += sayi2;
//}

//Console.WriteLine(toplam);

// n değeri dışarıdan girilmek üzere n! değerini hesaplayıp ekrana yazan
// programı yazınız. 

// 5! = 5 * 4 * 3 * 2 * 1
//for (int i = 0; i < 5; i++)
//{
//    // Artan Döngü
//}

//for(int i = 5; i >= 1; i--)
//{
//    // Azalan Döngü
//}

//Console.Write("Sayıyı giriniz ...:");
//string strSayi = Console.ReadLine();
//int sayi = Convert.ToInt32(strSayi);

//int faktoryel = 1;

//for (int i = sayi; i >= 1; i--)
//{
//    faktoryel *= i;
//}

//Console.WriteLine(faktoryel);


/*/
 *****
 ****
 ***
 **
 *
 /*/

// n adet kişi için VKI hesaplayıp ekranda listeleyen programı yazınız. 
// n sayısı dışarıdan girilecek. 
// VKI = (kilo / (boy * boy)) * katsayı
// VKI (Vücut Kitle Indeksi)

Console.Write("Kişi sayısını giriniz ..:");
string strKs = Console.ReadLine();
int ks = Convert.ToInt32(strKs);

for (int i = 1; i <= ks; i++)
{
	Console.Write("Kilo giriniz ...:");
	string strKilo = Console.ReadLine();
	int kilo = Convert.ToInt32(strKilo);

	Console.Write("Boy giriniz ...:");
	string strBoy = Console.ReadLine();
	double boy = Convert.ToDouble(strBoy);

	Console.Write("Cinsiyet giriniz ...:");
	string cinsiyet = Console.ReadLine();

	double katSayi = 0.8;
	if (cinsiyet.ToUpper() == "E")
	{
		katSayi = 1.3;
	}

	double VKI = (kilo / (boy * boy)) * katSayi;
	Console.WriteLine(VKI);
	Console.WriteLine("-----------------------------");
}