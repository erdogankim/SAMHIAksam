using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19_Oop_Ornek2
{
    public class CategoryRepository
    {
        public void Add(Category category)
        {
            //Console.WriteLine(category.CategoryName);
            //Console.WriteLine(category.Description);

            //Console.WriteLine("Veri tabanına eklendi");

            // git sql e bağlan
            SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=Northwind; User Id=sa; Password=1;TrustServerCertificate=True") ;
            cnn.Open();

            // Komutu oluştur. 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into Categories(CategoryName, Description) Values('" + category.CategoryName + "', '"+category.Description+"')";
            cmd.Connection = cnn;

            // Komutu çalıştır
            cmd.ExecuteNonQuery();

            cnn.Close();

        }
    }
}
