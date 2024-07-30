using Microsoft.Data.SqlClient;
// Connection nesnesi oluştur
SqlConnection cnn = new SqlConnection();
// Connection nesnesinin bağlantı string değerini belirle
// (hangi servera, hangi database e, hangi kullanıcı yöntemi ve bilgileri ile bağlanacak) 
cnn.ConnectionString = "Server=.;Database=Northwind;User Id=sa;Password=1;TrustServerCertificate=true";
// Bağlantıyı aç
cnn.Open();
SqlCommand cmd = new SqlCommand("Select * From Categories", cnn);

SqlDataReader rdr = cmd.ExecuteReader();

while (rdr.Read())
{
    Console.WriteLine(rdr["CategoryName"]);
}

