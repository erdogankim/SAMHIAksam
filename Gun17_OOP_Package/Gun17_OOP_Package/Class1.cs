namespace Gun17_OOP_Package
{
    public class MatematikIslemler
    {
        public double Faktoryel (int n)
        {
            double nFaktoryel = 1;
            for (int i = 1; i <= n; i++)
            {
                nFaktoryel *= i;
            }

            return nFaktoryel;
        }

        public double Kombinasyon (int n, int r)
        {
            double nFaktoreyel = Faktoryel(n);
            double rFaktoryel = Faktoryel(r);
            double nEksiRFaktoryel = Faktoryel(n-r);

            double sonuc = nFaktoreyel / (rFaktoryel * nEksiRFaktoryel);
            return sonuc;
        }
    }
}
