internal class Program
{
    private static void Main(string[] args)
    {
        string yol = "c:\\Projects\\mytemp.txt";
        DosyaIslem dosyaIslem = new DosyaIslem(yol);
        string metinIcerigi = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum numquam blanditiis harum \r\n \t\t\t quisquam eius sed odit fugiat iusto fuga praesentium optio, eaque rerum! Provident similique accusantium nemo autem.";
        dosyaIslem.DosyayaYaz(metinIcerigi);
        Console.WriteLine("Dosyaya metin yazıldı.");
    }
}

public class DosyaIslem
{
    string _yol;

    public DosyaIslem(string yol)
    {
        _yol = yol;
    }

    public void DosyayaYaz(string metin)
    {
        File.WriteAllText(_yol, metin);
    }

    public void DosyadanOku()
    {
   
    }

    public void DosyayıSil()
    {
        
    }
}