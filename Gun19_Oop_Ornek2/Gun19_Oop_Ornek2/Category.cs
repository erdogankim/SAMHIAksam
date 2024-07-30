using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19_Oop_Ornek2
{
    // Entity : Bir veri kayanağındaki şemanın birebir karşığılı olan nesnedir
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
