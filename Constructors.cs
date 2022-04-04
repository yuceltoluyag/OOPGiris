using System;


namespace ClassTuttorial
{


    public class Musteri
    {
        public int ID;
        public string Name;
        /* #Constructors
         * ilk olarak çağrılır
         * Sınıf İsmiyle Aynı Olmak Zorundadır
         * Overloading Olabilir
         */
        public Musteri(int id, string Name)
        {
            this.ID = id;
            this.Name = Name;
            Console.WriteLine("Yapıcı Method Çağrıldı");
        }

        public void PrintName() 
        {
            Console.WriteLine("ID = {0} Name = {1}",this.ID,this.Name);
        }



    }
    class Program
    {
        static void Main()
        {
            Musteri m = new Musteri(1, "Ali Veli");
            m.PrintName();


            Console.ReadKey();
        }
    }
}
