//DateTime tarih;
//tarih = new DateTime();

//tarih = new DateTime(2024, 5, 14, 20, 59, 30); // 14.05.2024 20:59:30

//tarih = DateTime.Now;

//string[] formats = tarih.GetDateTimeFormats();

////Console.WriteLine(tarih);

//for (int i = 0; i < formats.Length; i++)
//{
//    Console.WriteLine(formats[i]);
//}


// Dışarıdan girilen tarih değerini alıp, üzerine 1 ay ekleyip ekrana yazdırınız. 

//Console.Write("Tarih değerini giriniz ...:");
//string strTarih = Console.ReadLine();

//DateTime tarih = Convert.ToDateTime(strTarih);
//DateTime yeniTarih = tarih.AddMonths(1);
//Console.WriteLine(yeniTarih);


// Dışarıdan girilecek olan n kadar tarihi tek bir dizi değişkende tutan, 
// daha sonra bu değerlerin üzerlerine 1 yıl 2 ay 3 er gün ekleyerek 
// ekrana yazdıran programı yazınız. 

//Console.Write("Tarih sayısını giriniz ...:");
//int tarihSayisi = Convert.ToInt32(Console.ReadLine());

//DateTime[] arrTarih = new DateTime[tarihSayisi];

//for (int i = 0; i < tarihSayisi; i++)
//{
//    Console.Write("Tarih giriniz ...:");
//    string strTarih = Console.ReadLine();
//    DateTime tarih = Convert.ToDateTime(strTarih);
//    arrTarih[i] = tarih.AddYears(1).AddMonths(2).AddDays(3);
//}

//for (int i = 0; i < tarihSayisi; i++)
//{
//    Console.WriteLine(arrTarih[i]);
//}


//DateTime suAn = DateTime.Now;
//Console.WriteLine(suAn);

//long ticksDeegeri = suAn.Ticks;
//Console.WriteLine(ticksDeegeri);