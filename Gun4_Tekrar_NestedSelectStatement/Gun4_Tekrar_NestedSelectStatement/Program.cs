
/* Yurt kayıt otomasyonu geliştiriyoruz. 
 * Dışarıdan, Kaçıncı sınıf olduğu, Sınıf tekrarı durumu olup olmadığı ve şehir
 * bilgileri girilecek. 
 * 
 * Girilen bilgiler doğrultusunda odenmesi gereken yurt ücretini hesaplayınız. 
 * 
 * Hesaplama:
 * 1. ve 2. sınıflar için aylık 2500 TL
 * 3. ve 4. Sınıflar için aylık 3500 TL
 * 
 * Hazırlık sınıfları için aylık 2000 TL
 * 
 * --
 * Sınıf tekrarı durumu söz konusu olursa, kişiye aylık bazında %30 ek cezai 
 * ücret uygulanır. 
 * 
 * -- 
 * Kişinin ikameti eğer Antalyada ise kendisine yurt hakkı tanınmaz. 
 * 
 * Toplam Ucret = (AylıkUcret * 8) + Ceza Ucreti
 * 
 * 
*/


Console.Write("Lütfen şehir bilgisini giriniz ...:");
string sehir = Console.ReadLine();

if (sehir == "Antalya")
{
    Console.WriteLine("Antalyada ikamet edenler için yurt kaydı yapılamaz");
}
else
{
    Console.Write("Sınıf bilgisini giriniz ...:");
    string sinif = Console.ReadLine();

    Console.Write("Sınıf tekrarı durumu [E/H] ...:");
    string tekrar = Console.ReadLine();

    decimal aylikUcret = 0; // Varsayılan değer ataması
    if (sinif == "1" || sinif == "2")
    {
        aylikUcret = 2500;
    }
    else if (sinif == "3" || sinif == "4")
    {
        aylikUcret = 3500;
    }
    else
    {
        aylikUcret = 2000;
    }


    decimal araToplam = aylikUcret * 8;
    decimal cezaUcreti = 0;

    if (tekrar == "E")
    {
        cezaUcreti = araToplam * 0.3M;
    }

    decimal toplam = araToplam + cezaUcreti;

    Console.Write("Toplam ödeme = ");
    Console.WriteLine(toplam);
}

Console.ReadLine();