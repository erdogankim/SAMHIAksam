// Program çalıştığında, 
// Ürün Adı, Yıl, Toplam Satış tutarı

// şeklindeki listeyi ekranda gösteren programı yazınız. 

using Microsoft.Data.SqlClient;


Console.Write("Yıl bilginisi giriniz ...:");
string strYil = Console.ReadLine();

Console.Write("Ay bilgisini giriniz ...:");
string strAy = Console.ReadLine();

// Connection nesnesi oluştur
SqlConnection cnn = new SqlConnection();
// Connection nesnesinin bağlantı string değerini belirle
// (hangi servera, hangi database e, hangi kullanıcı yöntemi ve bilgileri ile bağlanacak) 
cnn.ConnectionString = "Server=.;Database=Northwind;User Id=sa;Password=1;TrustServerCertificate=true";
// Bağlantıyı aç
cnn.Open();