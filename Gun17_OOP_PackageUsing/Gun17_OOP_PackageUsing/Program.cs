using System;
using Gun17_OOP_Package;

MatematikIslemler islemler = new MatematikIslemler();

Console.Write("n değerini giriniz ...: ");
int n = Convert.ToInt32(Console.ReadLine());

// Faktöryel Hesabı yapılacak
double faktoryelSonuc = islemler.Faktoryel(n);
Console.WriteLine(faktoryelSonuc);

Console.Write("r değerini giriniz ....:");
int r = Convert.ToInt32(Console.ReadLine());


// kombinasyon
double kombinasyonSonuc = islemler.Kombinasyon(n, r);
Console.WriteLine(kombinasyonSonuc);