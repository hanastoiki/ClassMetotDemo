using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Elvis Presley";
            musteri1.KimlikNo = "123456789";
            musteri1.DogumYili = "1935";

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Amy Winehouse";
            musteri2.KimlikNo = "987654321";
            musteri2.DogumYili = "1983";

            Musteri musteri3 = new Musteri();
            musteri3.AdSoyad = "Michael Jackson";
            musteri3.KimlikNo = "741852963";
            musteri3.DogumYili = "1958";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};
           

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Kimlik No :" + " " + musteri.KimlikNo);
                Console.WriteLine("Müşteri Adı-Soyadı:" + " " + musteri.AdSoyad);
                Console.WriteLine("Müşteri Doğum Yılı:" + " " + musteri.DogumYili);
                Console.WriteLine("-------------------");
            }

            

        }
    }
}
