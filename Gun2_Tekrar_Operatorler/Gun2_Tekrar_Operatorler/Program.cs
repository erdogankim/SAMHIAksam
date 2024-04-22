// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 5 + 3;

// İşlevleri bakımından 

// Aritmetik Operatorler +,-,*,/, %,  

// Karşılaştırma Operatörleri ==, !=, <, <=, >, >= 
// (JS dilinde === (denklik kontrolü), !== (denk değil kontrolü) ) 1, true
// 1 === true  => false
// 1 == true  => true

// Atama operatörleri    =, +=, -=, *=,  /=, ++, --

// Mantıksal operatörler    &&,   ||


// Operadn sayıları bakımından 
// Tek operandılar ++, --
// İki operandlılar    +,-,*,/ 



int b = 7;
b += 10;
b -= 2;
b *= 3;
b /= 15;

b++;
a--;


bool sonuc1 = b == a;


int sayi1 = 20;
int sayi2 = sayi1++;
Console.WriteLine(sayi1);

int sayi3 = sayi1 + (++sayi2);
int sayi4 = sayi3 + (sayi2++);
Console.WriteLine(sayi2);


// üç operandlılar     ? :

int sayi5 = sayi3 > sayi2 ? 10 : 20; // Trinary Operator

string isim = sayi3 > sayi2 ? "Ahmet" : "Mehmet";

int sayi6 = sayi3 > sayi4 ? 10 : (sayi2 > sayi4 ? 30 : 40);


// Type Convert (Tür Dönüşümler)
// 1- Bilinçsiz tür dönüşümü (Implicit Convert)
// 2- Bilinçli tür dönüşümü (Explicit Convert)




