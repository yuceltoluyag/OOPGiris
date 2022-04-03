using System;


namespace OOPGiris
{
     class Program
    {
        static void Main()
        {
            Program p = new Program();
            int sonuc = p.topla(3, 2);
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }

        private int topla (int a, int b)
        {
            return a + b;
        }
    }
}
