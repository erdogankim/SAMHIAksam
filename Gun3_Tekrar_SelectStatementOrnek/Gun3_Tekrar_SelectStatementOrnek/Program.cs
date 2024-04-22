Console.Write("Çalıştığı gün sayısını giriniz ...:");
string strCGS = Console.ReadLine();
int CGS = Convert.ToInt32(strCGS);

Console.Write("Günlük maaşı giriniz ...:");
string strGunlukMaas = Console.ReadLine();
int gunlukMaas = Convert.ToInt32(strGunlukMaas);

Console.Write("Rütbesini giriniz [P/S/M] ...:");
string rutbe = Console.ReadLine();

Console.Write("Medeni durumunu giriniz [E/B] ...:");
string medeniDurum = Console.ReadLine();

int yonetimPrimi = 0;
if (rutbe == "S")
{
    yonetimPrimi = 1500;
}
else if (rutbe == "M")
{
    yonetimPrimi = 3000;
}

int AGI = 0;

if (medeniDurum == "E")
{
    AGI = 550;
}
else
{
    AGI = 350;
}

int toplamHakedis = (CGS * gunlukMaas) + AGI + yonetimPrimi;

Console.Write("Toplam hakediş ....:");
Console.WriteLine(toplamHakedis);
Console.ReadLine();