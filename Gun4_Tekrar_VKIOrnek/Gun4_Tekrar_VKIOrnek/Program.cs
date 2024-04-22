/*
 * Vücut Kitle Indeksi hesaplama uygulaması yapıyoruz 
 * - Dışarıdan Kilo (kg). Boy (m) ve Cinsiyet bilgileri girilecek. 
 * - VKI = (kilo / (boy * boy)) * katsayi
 * - Katsayi= Erkekler -> 1.2, Kadnlar -> 0.8 
 * 
 * şeklinde hesaplanır. 
 * 
 */


Console.Write("Kilo bilgisini giriniz (Kg) ..:");
string strKilo = Console.ReadLine();
double kilo = Convert.ToDouble(strKilo);

Console.Write("Boy bilgisini giriniz (Boy) ..:");
string  strBoy = Console.ReadLine();
double boy = Convert.ToDouble(strBoy);

Console.WriteLine("Cinsiyet bilgini giriniz [K/E] ..:");
string cinsiyet = Console.ReadLine();

double katSayi = 1.2;
if (cinsiyet == "K")
{
    katSayi = 0.8;
}

//double VKI = (kilo / (boy*boy)) * katSayi;
double VKI = (kilo / Math.Pow(boy,2)) * katSayi;

Console.WriteLine(VKI);



