using System;


namespace ClassTuttorial
{
    public class Musteri
    {
        public int ID;
        public string Name;
        public string Surname;

        public void Info()
        {
            Console.WriteLine("Müşteri Bilgileri ID: {0} Name: {1} {2}",ID,Name,Surname);
            
        }
    }
    class Program
    {
        static void Main()
        {
            Musteri musteri = new Musteri();
            musteri.ID = 1;
            musteri.Name = "Adam";
            musteri.Surname = "Coder";
            musteri.Info(); 

            Musteri m2 = new Musteri();
            m2.ID= 2;
            m2.Name = "Cabbar";
            m2.Surname = "Adam";
            m2.Info();

            Console.ReadKey();
        }
    }
}
