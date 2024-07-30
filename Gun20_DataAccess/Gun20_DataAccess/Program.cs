using Microsoft.Data.SqlClient;
// Connection nesnesi oluştur
SqlConnection cnn = new SqlConnection();
// Connection nesnesinin bağlantı string değerini belirle
// (hangi servera, hangi database e, hangi kullanıcı yöntemi ve bilgileri ile bağlanacak) 
cnn.ConnectionString = "Server=.;Database=Northwind;User Id=sa;Password=1;TrustServerCertificate=true";
// Bağlantıyı aç
cnn.Open();

// Sql komut nesnesi oluştur. 
SqlCommand cmd = new SqlCommand();
// Komut nesnesinin bağlantısını belirle
cmd.Connection = cnn;
// Komut satırını belirle
cmd.CommandText = "Insert Into Categories(CategoryName, Description) Values('DENEME1','DENEME1')";
// Komut bir insert cümlesi olduğu için NonQuery çalışma şekliyle çalıştır. 
int eklenenhSatir = cmd.ExecuteNonQuery();
// sonucu ekrana yaz
Console.WriteLine(eklenenhSatir);

SqlCommand cmdTotalProductCount = new SqlCommand("Select Count(*) From Products",cnn);

object objResult = cmdTotalProductCount.ExecuteScalar();
Console.WriteLine(objResult);

