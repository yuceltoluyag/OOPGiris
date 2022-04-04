using System;

namespace ClassTuttorial
{
    public class Daire
    {

        /*
         * Static değerlere sınıf ismi üzerinden ulaşılır.
         * Static Bir method içerisinden static olmayan bir veri yada değişken çağrılamaz.
         * Static yapıcı methodların erişim belirteci olmaz ve parametrede almazlar. Public,private vs
         */
        int _r;
        static float _PI = 3.14f;

        static Daire()
        {
            Daire._PI = 3.14f;
            Console.WriteLine("Yapıcı Method Çağrıldı");
        }

        // constr
        public Daire(int r)
        {
            this._r = r;
        }

        public float AlanHesapla()
        {
            return this._r * this._r * Daire._PI;
        }
    }
}
