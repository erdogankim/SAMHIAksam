// See https://aka.ms/new-console-template for more information
//Console.Write("Ahmet");
//Console.Write("Mehmet");
//Console.WriteLine("Hasan");
//Console.Write("Hüseyin");

//Console.Write("Lütfen bir sayı giriniz ...:");
//string strResult = Console.ReadLine();

//Console.Write("girilen sayı ....:");
//Console.WriteLine(strResult);


// Dışarıdan, Çalıştığı gün sayısı, günlük maaşı bilgileri girilmek suretiyle
// toplam hakedişini hesaplayan ve ekranda gösteren programı yazınız. 

// TH = ÇGS * GM;


Console.Write("Çalıştığı gün sayısını giriniz ...:");
string strCGS = Console.ReadLine();
int CGS = Convert.ToInt32(strCGS);

Console.Write("Günlük hakedişini giriniz ...:");
string strHakedis = Console.ReadLine();
int hakedis = Convert.ToInt32(strHakedis);

int toplamHakedis = CGS * hakedis;
Console.Write("Toplam Hakediş : ");
Console.WriteLine(toplamHakedis);


