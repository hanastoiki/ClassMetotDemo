using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi!" + " ' " + musteri.AdSoyad + "'");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!" + "'" + musteri.AdSoyad + "'");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad);
            Console.WriteLine("------------");
        }




    

       

    }
}
