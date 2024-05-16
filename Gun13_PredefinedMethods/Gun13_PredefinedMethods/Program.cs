//string isim = "Ahmet";

//bool durum = isim.Contains("z");

//if (durum)
//{
//    Console.WriteLine("İsim değişkeni belirtilen karakteri içeriyor. ");
//}
//else
//{
//    Console.WriteLine("İsim değişkeni belirtilen karakteri içermiyor.");
//}

//string subStr = isim.Substring(2,2);
//Console.WriteLine(subStr);

//bool baslangicDurum = isim.StartsWith("Bh");

//if (baslangicDurum)
//{
//    Console.WriteLine("isim değişkeni belirtilen karakterler ile başlıyor");
//}

//string buyukIsim = isim.ToUpper();
//Console.WriteLine(buyukIsim);

//DateTime dt = DateTime.Now;

//DateTime dtYeni = dt.AddYears(-1).AddMonths(-2).AddDays(-3);
//Console.WriteLine(dtYeni);

//int a = 10;
//a.ToString();

//DateTime dt2 = new DateTime(1900,1,1,0,0,0);


//int[] arr = new int[10];
//for (int i = 0; i < 9; i++)
//{
//    arr[i] = i+1;
//    Console.WriteLine(arr[i]);
//}
//Console.WriteLine("----------------");
//var filtrelenmis = (from sayi in arr
//                   where sayi > 3 && sayi < 8
//                   select sayi).ToList();

//for (int i = 0;i < filtrelenmis.Count(); i++)
//{
//    Console.WriteLine(filtrelenmis[i]);
//}


// .net DateTime türünde Ticks adı verilen bir değer vardır. 
// Bu değer, herhangi bir tarihin tamamen sayısal olan long türündeki karşığılını verir. 


DateTime dt = new DateTime(1986, 11, 22, 0, 35, 0);
Console.WriteLine(dt);
Console.WriteLine(dt.Ticks);

// Belirtilen örneğe göre, dışarıdan girilen 3 farklı tarihin ortalama tarihini 
// hesaplayıp, ekrana tarih olarak yazan programı yazınız. 
