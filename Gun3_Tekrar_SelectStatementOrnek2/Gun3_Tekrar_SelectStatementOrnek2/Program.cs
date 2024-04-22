/*
 * ASAT'a mobil uygulamalarında kullanacağı bir su faturası hesaplama uygulaması geliştiriyoruz
 * 
 * Dışarıdan sonindex, ilkindex ve kullanım yeri bilgileri girilecektir
 * kullanılanSuMiktarı = sonindex - ilkindex
 * 
 * kullanım yerine göre litre birim fiyatı :
 *    Mesken => 3.5
 *    Umumi => 2.7
 *    Kamu =>> 1.3
 *    
 * FaturaTutari = (kullanılanSuMiktarı * birimFiyat) + kanalizasyonvegiderucreti + KDV
 * 
 * 
 * Kanalizasyon ve gider ücreti
 *     Meskenler => 2.5
 *     Umumiler => 1.5
 *     Kamuda alınmaz
 *     
 * KDV %18
 * 
 */

#region Girişler
Console.Write("Son index değerini giriniz ...:");
string strSonIndex = Console.ReadLine();
int sonIndex = Convert.ToInt32(strSonIndex);

Console.Write("İlk index değerini giriniz ...:");
string strIlkIndex = Console.ReadLine();
int ilkIndex = Convert.ToInt32(strIlkIndex);

Console.Write("Kullanım yerini giriniz [M/U/K] ...:");
string kullanimYeri = Console.ReadLine();

#endregion

double kullanilanSu = sonIndex - ilkIndex;
double birimFiyat = 0;
double kanalizasyonGideri = 0;

if (kullanimYeri == "M")
{
    birimFiyat = 3.5;
    kanalizasyonGideri = 2.5;
}
else if (kullanimYeri == "U")
{
    birimFiyat = 2.7;
    kanalizasyonGideri = 1.5;
}
else
{
    birimFiyat = 1.3;
}

double araToplam = (birimFiyat * kullanilanSu) + kanalizasyonGideri;
double KDV = araToplam * 0.18;
double toplam = araToplam + KDV;

Console.Write("Toplam = ");
Console.WriteLine(toplam);
Console.ReadLine();