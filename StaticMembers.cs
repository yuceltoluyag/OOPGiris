using System;


namespace ClassTuttorial
{


    class Program
    {
        static void Main()
        {
            Daire d1 = new Daire(2);
            float alan1 = d1.AlanHesapla();
            Console.WriteLine(alan1);

            Daire d2 = new Daire(4);
            float alan2 = d2.AlanHesapla();
            Console.WriteLine(alan2);

            Console.ReadKey();
        }
    }
}
