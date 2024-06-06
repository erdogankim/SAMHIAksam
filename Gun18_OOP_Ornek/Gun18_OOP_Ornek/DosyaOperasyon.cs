using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gun18_OOP_Ornek
{
    public class DosyaOperasyon
    {
        public void YeniOlustur(string dosyaYolu)
        {
            bool durum = File.Exists(dosyaYolu);
            if (!durum)
            {
                File.Create(dosyaYolu);
            }
        }
    }
}
