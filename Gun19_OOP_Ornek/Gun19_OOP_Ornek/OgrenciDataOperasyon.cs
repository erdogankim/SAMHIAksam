using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19_OOP_Ornek
{
    public class OgrenciDataOperasyon
    {
        public void Ekle(Ogrenci prmOgrenci)
        {
            Console.WriteLine(prmOgrenci.TCKN);
            Console.WriteLine(prmOgrenci.Ad);
            Console.WriteLine(prmOgrenci.Soyad);

            Console.WriteLine("DB ye eklendi");
        }
    }
}
