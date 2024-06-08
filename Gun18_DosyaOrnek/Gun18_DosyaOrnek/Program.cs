// See https://aka.ms/new-console-template for more information
// dışarıdan girilen metin değerini yine dışarıdan girilen dosyaya yazan programı yazınız. 

// Metni giriniz ...: ylumikeaylukieaylkuiaylmkuiyalmkuieyalm
// Dosya yolunu giriniz ....: C:\Projects\mydocument.txt

// File.WriteAllText(path,content)

//Console.Write("Metni giriniz ...:");
//string metin = Console.ReadLine();

//Console.Write("Dosya yolunu giriniz ...:");
//string yol = Console.ReadLine();

//File.WriteAllText(yol, metin);
//Console.WriteLine("Dosya yazma başarılı");



Console.Write("Dosya yolunu giriniz ...:");
string yol = Console.ReadLine();

string content = File.ReadAllText(yol);
Console.WriteLine(content);



// Ödev sorusu
// bilgisayarda bir klasörde bulunan bir metin dosyasının içinde 3 satırdan fazla satır olsun
// Bu satırlardan ikinci ve üçüncü satırı ekrana yazan programı yazınız. 