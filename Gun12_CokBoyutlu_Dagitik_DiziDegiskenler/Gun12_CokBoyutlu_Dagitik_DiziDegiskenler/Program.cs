Random rnd = new Random();
// Düzenli dizi değişkenler
int[] myArr = new int[5];
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = rnd.Next(1, 100);
}


int[,] myMultiDimensionalArray = new int[2, 2];
for (int i = 0; i < myMultiDimensionalArray.Length; i++)
{
    for (int j = 0; j < myMultiDimensionalArray.GetLongLength(1); j++)
    {

    }
}


int[,,] my3DimensionalArray = new int[2, 2, 2];

int[,,,] my4DimensionalArray = new int[2, 2, 2, 2];

int[,,,,] my5DimensionalArray = new int[2, 2, 2, 2, 2];

// Düzensiz dizi değişken

int[][] arr = new int[3][];
arr[0] = new int[3];
arr[1] = new int[1];
arr[2] = new int[2];

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        arr[i][j] = rnd.Next(1, 100);
    }
}


// Okulun, beden eğitimi dersleri için sınıfa verilecek olan 
// basketbol, futbol ve voleybol top adetleri ve öğrenci isimlerinin 
// listesi şeklinde bir kayıt bütünü oluşturan programı geliştiriyoruz


// Basketbol top adedi
// voleybol top adedi
// futbol top adedi 
// öğrencilerin listesi

// Öğrenci sayısını giriniz ...: 5
// (5 öğreci için isim ve soyisimleri dışarıdan tekrar girilecek) 

// Basketbol topu sayısınız giriniz ...: 1
// Voleybol topu sayısını giriniz ...: 1
// Futbol topu sayısını giriniz ...: 2

Console.Write("Öğrenci sayısını giriniz ...:");
int ogrSayisi = Convert.ToInt32(Console.ReadLine());

string[][] data = new string[4][];
data[0] = new string[ogrSayisi];
data[1] = new string[1];
data[2] = new string[1];
data[3] = new string[1];

for (int i = 0;i < data[0].Length; i++)
{
    Console.Write("Ad Soyad bilgisini giriniz ....:");
    data[0][i] = Console.ReadLine();
}

Console.Write("Basket topu sayısını giriniz ...:");
data[1][0] = Console.ReadLine();

Console.Write("Volleybol topu sayısını giriniz ...:");
data[2][0] = Console.ReadLine();

Console.Write("Futbol topu sayısını giriniz ...:");
data[3][0] = Console.ReadLine();

