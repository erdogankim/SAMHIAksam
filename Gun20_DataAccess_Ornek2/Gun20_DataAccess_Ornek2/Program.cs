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
    Console.WriteLine(rdr["CategoryID"] +" - "+rdr["CategoryName"]);
}

Console.Write("Lütfen detay görmek istediğiniz kategorinin numarasını giriniz ...:");
string strCId = Console.ReadLine();

cnn.Close();
cnn.Open();

SqlCommand cmd2 = new SqlCommand("Select * From Products Where CategoryID = @cid",cnn);
cmd2.Parameters.AddWithValue("cid", strCId);

SqlDataReader rdr2 =  cmd2.ExecuteReader();
while (rdr2.Read())
{
    Console.WriteLine(rdr2["ProductName"]);
}