// See https://aka.ms/new-console-template for more information
// Kişi adında bir nesne oluşturun. 
// Bu nesnenin Kilo, Boy ve Cinsiyet özellikleri olsun. 

// VKI adında başka bir nesne oluşturun. 
// Bu nesnenin hesapla adında bir methodu olsun. 
// Bu method parametre olarak Kişi alsın. 
// Geriye hesaplanmış VKI değerini döndürsün. 

// VKI = (Kilo / (Boy * Boy)) * Katsayı
// Katsayı => Erkekler = 1,3 Kadınlar = 0,8 dir. 


public class VKI
{
    public double Hesapla(Kisi kisi)
    {
        double cinsiyetKatsayisi = 0;
        if (kisi.Cinsiyet == "Erkek")
        {
            cinsiyetKatsayisi = 1.3;
        }
        else
        {
            cinsiyetKatsayisi = 0.8;
        }

        double sonuc = (kisi.Kilo / (kisi.Boy * kisi.Boy)) * cinsiyetKatsayisi;
        return sonuc;

    }
}