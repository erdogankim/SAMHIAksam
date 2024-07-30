using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19_OOP_Ornek3
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            // Db ye bağlan
            SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=Northwind; User Id=sa; Password=1;TrustServerCertificate=True;");
            cnn.Open();

            // Okuma komutunu oluştur
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Products With(nolock)";
            cmd.Connection = cnn;

            // Okuyucu modülünü ayarla
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductName = reader["ProductName"].ToString();
                products.Add(product);
            }


            //Product p1 = new Product();
            //p1.ProductName = "Ürün 1";
            //p1.UnitPrice = 10;
            //products.Add(p1);

            //Product p2 = new Product();
            //p2.ProductName = "Ürün 2";
            //p2.UnitPrice = 20;
            //products.Add(p2);

            //Product p3 = new Product();
            //p3.ProductName = "Ürün 3";
            //p3.UnitPrice = 30;
            //products.Add(p3);

            //Product p4 = new Product();
            //p4.ProductName = "Ürün 4";
            //p4.UnitPrice = 40;
            //products.Add(p4);

            return products;
        }
    }
}
