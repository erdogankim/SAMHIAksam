Console.Write("1. Yazılı notunu giriniz...:");
string strYazili1 = Console.ReadLine();
byte yazili1 = Convert.ToByte(strYazili1);

Console.Write("2. Yazılı notunu giriniz...:");
string strYazili2 = Console.ReadLine();
byte yazili2 = Convert.ToByte(strYazili2);

//byte ortalama = Convert.ToByte((yazili1 + yazili2) / 2);

float ortalama = (yazili1 + yazili2) / 2;

string sonuc = "";

if (ortalama >= 0 && ortalama <= 24)
{
    sonuc = "Geçersiz";
}
else if (ortalama >= 24 && ortalama <= 44)
{
    sonuc = "Zayıf";
}
else if (ortalama >= 45 && ortalama <= 54)
{
    sonuc = "Geçer";
}
else if (ortalama >= 55 && ortalama <= 69)
{
    sonuc = "Orta";
}
else if (ortalama >= 70 && ortalama <= 84)
{
    sonuc = "İyi";
}
else  //if (ortalama >= 85 && ortalama <= 100)
{
    sonuc = "Pekiyi";
}

Console.Write("Durum : ");
Console.WriteLine(sonuc);





if (ortalama < 25)
{
    sonuc = "Geçersiz";
}
else if (ortalama < 45)
{
    sonuc = "Zayıf";
}
else if (ortalama < 55)
{
    sonuc = "Geçer";
}
else if (ortalama < 70)
{
    sonuc = "Orta";
}
else if (ortalama < 85)
{
    sonuc = "İyi";
}
else
{
    sonuc = "Pekiyi";
}
Console.WriteLine(sonuc);