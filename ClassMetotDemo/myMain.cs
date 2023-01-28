using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class myMain
    {
        public static void main()
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahsen";
            musteri1.Soyadi = "Kas";

            Musteri musteri2 = new Musteri();
            musteri2.Id=2;
            musteri2.Adi = "Samet";
            musteri2.Soyadi = "Kas";

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.MusteriEkle(musteri1);
            musteriManager1.MusteriEkle(musteri2);

            musteriManager1.MusteriListele(musteri1);
            musteriManager1.MusteriListele(musteri2);

            musteriManager1.Silme(musteri1);
            musteriManager1.Silme(musteri2);



        }

    }
}
