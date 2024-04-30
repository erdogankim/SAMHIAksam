// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// n ve r değerleri dışarıdan girilmek üzere
// n! / (r! * (n-r)!) sonucunu ekrana yazdıran programı yazınız. 


//////////// N Değeri alınıyor //////////////////
Console.Write("n sayısını giriniz ...:");
string strN = Console.ReadLine();
int n = Convert.ToInt32(strN);

int nFaktoryel = 1;

for (int i = n; i >= 1; i--)
{
    nFaktoryel *= i;
}


//////////// R Değeri alınıyor //////////////////
Console.Write("r sayısını giriniz ...:");
string strR = Console.ReadLine();
int r = Convert.ToInt32(strR);

int rFaktoryel = 1;

for (int i = r; i >= 1; i--)
{
    rFaktoryel *= i;
}

///////////// n-r faktoryel ///////////////////

int nEksiR = n - r;
int nEksiRFaktoryel = 1;
for (int i = nEksiR; i >= 1; i--)
{
    nEksiRFaktoryel *= i;
}

double sonuc = nFaktoryel / (rFaktoryel * nEksiRFaktoryel);
Console.WriteLine(sonuc);