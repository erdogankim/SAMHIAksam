// Soru2 : Program ilk çalıştığında kategorilerin listesi gelecek
// Örn : 
// 1 İçecekler
// 2 Condiments
// 3 Confections
// ...

// Daha sonra kişi  hangi kategori numarasını yazıp enter a basarsa
// o kategoriye ait ürünlerin isimleri listelenecek. 

// Soru : Dışarıdan yıl ve ay bilgisi girilen siparişlerin toplam tutarlarını
// ekranda gösteren programı yazınız. 
using Microsoft.Data.SqlClient;

Console.Write("Yıl bilginisi giriniz ...:");
string strYil = Console.ReadLine();

Console.Write("Ay bilginisini giriniz ...:");
string strAy = Console.ReadLine();


// Connection nesnesi oluştur
SqlConnection cnn = new SqlConnection();
// Connection nesnesinin bağlantı string değerini belirle
// (hangi servera, hangi database e, hangi kullanıcı yöntemi ve bilgileri ile bağlanacak) 
cnn.ConnectionString = "Server=.;Database=Northwind;User Id=sa;Password=1;TrustServerCertificate=true";
// Bağlantıyı aç
cnn.Open();
SqlCommand cmd = new SqlCommand("Select Sum(od.UnitPrice * od.Quantity) From Orders o Inner Join [Order Details] od On o.OrderID = od.OrderID Where Year(o.OrderDate) = @yil And Month(o.OrderDate) = @ay", cnn);
cmd.Parameters.AddWithValue("yil", strYil);
cmd.Parameters.AddWithValue("ay", strAy);

object result = cmd.ExecuteScalar();
Console.WriteLine(result);