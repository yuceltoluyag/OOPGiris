using System;


namespace OOPGiris
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            /* Toplama İşlemi*/
            int sonuc = p.Topla(3, 2);
            Console.WriteLine("Toplam Sonucu {0}", sonuc);
            /* Çarpım İşlemi*/
            int carpimSonuc = Carp(3, 5);
            Console.WriteLine("Çarpım Sonucu {0}", carpimSonuc);
            /* Ekrana Yaz */
            p.EkranaYaz("Hello Windozort");
            Console.ReadKey();
        }

        private int Topla(int a, int b)
        {
            return a + b;
        }

        static int Carp(int x, int y)
        {
            return x * y;
        }

        private void EkranaYaz (string input)
        {
            Console.WriteLine(input);
        }
    }
}
