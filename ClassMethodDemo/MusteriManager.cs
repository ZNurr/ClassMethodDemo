using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi:"+musteri.MusteriAdi);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi:"+musteri.MusteriAdi);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi:"+musteri.MusteriAdi);
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi:"+musteri.MusteriAdi);
        }
    }
}
