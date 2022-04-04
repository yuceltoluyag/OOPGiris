using System;


namespace ClassTuttorial
{

    public class Ogrenci
    {
        private int _ID;
        private string _Name;
        private static int _Devamsizlik = 20;

        public void SetID(int ID)
        {
            if (ID <= 0)
            {
                Console.WriteLine("ID Sıfırdan Küçük Olamaz");
            }
            else
            {
                this._ID = ID;
            }
        }

        public int GetID()
        {
            return this._ID;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("İsim Alanı Boş Olamaz");
            }
            else
            {
                this._Name = Name;
            }
        }

        public string GetName()
        {

            if (string.IsNullOrEmpty(this._Name))
            {
                return "İsim Girilmemiş";
            }
            else
            {
                return this._Name;
            }

        }

        public int GetDevamsizlik()
        {
            return Ogrenci._Devamsizlik;
        }


        class Program
        {
            static void Main()
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.SetID(1);
                ogrenci.SetName("Ahmet");
                Console.WriteLine("ID= {0} Name {1} Devamsızlık {2}", ogrenci.GetID(), ogrenci.GetName(),ogrenci.GetDevamsizlik());
                Console.ReadKey();
            }
        }
    }
}
