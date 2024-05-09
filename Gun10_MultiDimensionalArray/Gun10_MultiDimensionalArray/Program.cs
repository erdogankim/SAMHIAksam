//int a = 5;

//int[] arr1D = new int[3];
//arr1D[0] = 10;
//arr1D[1] = 20;
//arr1D[2] = 30;



//int[,] arr2D = new int[2, 2];
//arr2D[0, 0] = 40;
//arr2D[1, 0] = 50;
//arr2D[0, 1] = 60;
//arr2D[1, 1] = 70;

// içi 1-100 arası sayılarla doldurulmuş 3x3 bir matris oluşturun

//int[,] arr2D = new int[3, 3];

//Random rnd = new Random();

//for (int i = 0; i < 3; i++)
//{
//	for (int j = 0; j < 3; j++)
//	{
//		arr2D[i, j] = rnd.Next(1, 100);
//	}
//}

// n değeeri dışarıdan girilmek üzere, nxn lik birim matrisi
// oluşturan programı yazınız. 
Console.Write("n değerini giriniz ...:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr2D = new int[n, n];

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		if (i == j)
		{
			arr2D[i, j] = 1;
		}
		else
		{
			arr2D[i, j] = 0;
		}
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.Write(arr2D[i,j] + " ");
    }
    Console.WriteLine();
}