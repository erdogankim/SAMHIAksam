// Soru : Dışarıdan girilen Yıl ve Ay bilgilerine göre, o yılın o ayına ait, personel
// bazında toplam satış listesini ekrana getiren programı yazınız. 
// Tüyo : Orders,Order Detalis, Employees tabloları

// FirstName , LastName, TotalSales  

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

string sql = "Select e.FirstName, e.LastName, Sum(od.UnitPrice * od.Quantity) as Total From Orders o Inner Join [Order Details] od On o.OrderID = od.OrderID Inner Join Employees e On e.EmployeeID = o.EmployeeID Where Year(o.OrderDate) = @year And Month(o.OrderDate) = @month Group By e.FirstName, e.LastName";


SqlCommand cmd = new SqlCommand(sql, cnn);
cmd.Parameters.AddWithValue("year", strYil);
cmd.Parameters.AddWithValue("month", strAy);

SqlDataReader rdr = cmd.ExecuteReader();

while (rdr.Read())
{
    Console.WriteLine($"Ad : {rdr["FirstName"]} - Soyad: {rdr["LastName"]} - Toplam : {rdr["Total"]}");
    //Console.WriteLine(rdr["FirstName"] + " " + rdr["LastName"] + " " + rdr["Total"]);
}