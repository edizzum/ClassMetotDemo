using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri) { 
        Console.WriteLine (musteri.MusteriAdi + " : İsimli müşteri başarıyla eklendi.");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " : İsimli müşteri başarıyla silindi.");
        }
        public void MusteriIDŞifreleme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriID + " : Numaralı ID tekrar şifrelendi.");
        }
        public void MusteriAdresSorgulama(Musteri musteri)
        {
            Console.WriteLine("Müşterinin adresi: " + musteri.MusteriAdres);
        }
        public void MusteriYasSorgulama(Musteri musteri)
        {
            Console.WriteLine("Müşterinin yaşı: " + musteri.MusteriYas);
        }
    }
}
