Random rnd = new Random();
// Düzenli dizi değişkenler
int[] myArr = new int[5];
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = rnd.Next(1,100);
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
