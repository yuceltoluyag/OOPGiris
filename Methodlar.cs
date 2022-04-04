using System;


namespace Method
{
    class Program
    {
        static void Main()
        {
            /* i değişkeni method olarak kullandık ama 
             * hiçbirşeyden etkilenmedi sonuç 5 olarak döndü !
             * OrnekMethod()
             */
            int i = 5;
            OrnekMethod(i);
            OrnekMethod2(ref i); // Sonuç 100 olarak döndü
            Console.WriteLine(i);

            int Toplam;
            int Carpim;
            Hesapla(10, 20, out Toplam, out Carpim);
            Console.WriteLine("Toplam = {0} ve Çarpım Sonucu {1}", Toplam, Carpim);

            int[] _Numbers = new int[] {1,2,3,4,5};
            // Dizi Oluşturmadanda Yapılabilir ParametreMethodu(1,2,3,4,5,6);
            ParametreMethodu(_Numbers);


            Console.ReadKey();
        }

        public static void OrnekMethod(int a)
        {
            a = 100;
        }

        public static void OrnekMethod2(ref int b)
        {
            b = 100;
        }

        // Out

        public static void Hesapla(int Fn, int Sn, out int Sum, out int Product)
        {
            Sum = Fn + Sn;
            Product = Fn * Sn;
        }

        // Param Arrays

        public static void ParametreMethodu(params int[] Numbers)
        {
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
