// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Tür Dönüşümü (c# dili kullanarak tür dönüşümü)
// 1- Bilinçsiz tür dönüşümü (Implicit Convert) 
// Küçük türün, büyük türe dönüşmesi
byte sayi1 = 10;
int sayi2 = sayi1;

// 2- Bilinçli tür dönüşümü (Explicit Convert)
// Büyük türün, küçük türe dönüşmesi

short sayi3 = 20;
byte sayi4 = (byte)sayi3;


short sayi5 = 257;

Console.WriteLine(sayi5);

byte sayi6 = (byte)sayi5;
Console.WriteLine(sayi6);

// library kullanarak tür dönüşümü 
int sayi7 = Convert.ToByte(sayi5);

string yazi = "34578";
int sayi = Convert.ToInt32(yazi);

string yazi2 = Convert.ToString(sayi);
string yazi3 = sayi.ToString();


Console.Write();
Console.WriteLine();
Console.ReadLine();
