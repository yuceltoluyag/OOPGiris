using System;


namespace ClassTuttorial
{
    // Inheritance Metot 

    public class BaseClass
    {
        // Cons
        /*
         *  Türetilmiş sınıftan bir yapıcı method oluşturulup çağrılırsa
         *  Öncelikle BaseClassın içerisinde ki yapıcı method çağrılır.
         */

        public BaseClass()
        {
            Console.WriteLine("BaseClass Yapıcı Method Çalıştırıldı");
        }

        // Paremetri şekilde deniyoruz acaba hangisi çağrılacak

        /*
         * Yine Parametresiz olanı çağırdı.
         * Eğer parametreli olanı çağırmak istiyorsa base anahtar sözcüğünü kullanmalıyız.
         */

        public BaseClass(string Message)
        {
            Console.WriteLine(Message);
        }

    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base("Parametreli olan") //Parametreli olanı çağırıyoruz
        {
            Console.WriteLine("DerivedClass Yapıcı Method Çalıştırıldı");

        }
    }
    class Program
    {
        static void Main()
        {
            DerivedClass dcs = new DerivedClass();

            Console.ReadKey();
        }
    }

}

