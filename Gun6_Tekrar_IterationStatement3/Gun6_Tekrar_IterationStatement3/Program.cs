// n sayısı dışrıdan girilmek üzere, 
// rastgele n adet sayının kareleri toplamını ekrana yazdıran programı yazınız. 

Console.Write("n sayısını giriniz ...:");
string strN = Console.ReadLine();
int n = Convert.ToInt32(strN);

Random rnd = new Random();


int toplam = 0;

for (int i = 1;i <= n; i++)
{
    int rastgeleSayi = rnd.Next(1,10);
    Console.WriteLine(rastgeleSayi);
    toplam += rastgeleSayi * rastgeleSayi;
}
Console.WriteLine(toplam);