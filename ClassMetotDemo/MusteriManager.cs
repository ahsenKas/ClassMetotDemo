using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi " +" "+musteri.Id+  "  "+musteri.Adi +" " +musteri.Soyadi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi " +musteri.Adi +" " +musteri.Id);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Litelendi " +musteri.Id+ " " +musteri.Adi);
        }
    }
}
