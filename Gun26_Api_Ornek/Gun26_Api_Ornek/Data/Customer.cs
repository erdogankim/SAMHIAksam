using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gun26_Api_Ornek.Data
{
    [Table("Customers")]
    public class Customer
    {

        [Key] public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}
