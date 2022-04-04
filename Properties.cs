using System;


namespace ClassTuttorial
{
    // Properties

    /*
     * Value Anahtar kelimesi Özelliğe Atanacak nesnenin değerini ifadereder value = ID
     * get ve set kullanarak okuma yazma özelliği verilir.
     * Yazım Sırası Önemli değildir
     * Özellik isimleri ilgili alanla aynı adla olursa akılda kalıcı olur :)
     
     */
    public class Ogrenci
    {
        private int _ID;
        private string _Name;
        private static int _Devamsizlik = 20;

        public int No { get; set; }
        public int ID
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ID Sıfırdan Küçük Olamaz");
                }

                this._ID = value;

            }

            get
            {
                return this._ID;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("İsim Alanı Boş Olamaz");
                }

                this._Name = value;

            }
            get
            {
                if (string.IsNullOrEmpty(this._Name))
                {
                    return "İsim Girilmemiş";
                }

                return this._Name;

            }
        }

        public int Devamsizlik
        {
            get
            {
                return Ogrenci._Devamsizlik;
            }
        }



        class Program
        {
            static void Main()
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.ID = 32;
                ogrenci.Name = "Yücel";
                ogrenci.No = 189;
                Console.WriteLine("ID= {0} Name {1} Öğrenci Numaranız {2} Devamsızlık Hakkınız {3}", ogrenci.ID, ogrenci.Name, ogrenci.No,ogrenci.Devamsizlik);

                Console.ReadKey();
            }
        }
    }
}
