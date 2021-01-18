using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Yücel";
            musteri1.MusteriAdres = "Washington D.C";
            musteri1.MusteriID = "12345678912";
            musteri1.MusteriYas = 19;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Güney";
            musteri2.MusteriAdres = "New York";
            musteri2.MusteriID = "12345672456";
            musteri2.MusteriYas = 19;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Can";
            musteri3.MusteriAdres = "Konya";
            musteri3.MusteriID = "68593562485";
            musteri3.MusteriYas = 26;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAdi = "Selman";
            musteri4.MusteriAdres = "İzmir";
            musteri4.MusteriID = "45645672456";
            musteri4.MusteriYas = 20;

            MusteriManager MusterininBilgileri = new MusteriManager();
            MusterininBilgileri.MusteriAdresSorgulama(musteri1);
            MusterininBilgileri.MusteriAdresSorgulama(musteri2);
            MusterininBilgileri.MusteriAdresSorgulama(musteri3);
            MusterininBilgileri.MusteriAdresSorgulama(musteri4);

            Console.WriteLine("\n");

            MusterininBilgileri.MusteriEkleme(musteri1);
            MusterininBilgileri.MusteriEkleme(musteri2);
            MusterininBilgileri.MusteriEkleme(musteri3);
            MusterininBilgileri.MusteriEkleme(musteri4);

            Console.WriteLine("\n");

            MusterininBilgileri.MusteriIDŞifreleme(musteri1);
            MusterininBilgileri.MusteriIDŞifreleme(musteri2);
            MusterininBilgileri.MusteriIDŞifreleme(musteri3);
            MusterininBilgileri.MusteriIDŞifreleme(musteri4);

            Console.WriteLine("\n");

            MusterininBilgileri.MusteriSilme(musteri1);
            MusterininBilgileri.MusteriSilme(musteri2);
            MusterininBilgileri.MusteriSilme(musteri3);
            MusterininBilgileri.MusteriSilme(musteri4);

            Console.WriteLine("\n");

            Console.Write(musteri1.MusteriAdi + " " + "İsimli" + " "); MusterininBilgileri.MusteriYasSorgulama(musteri1);
            Console.Write(musteri2.MusteriAdi + " " + "İsimli" + " "); MusterininBilgileri.MusteriYasSorgulama(musteri2);
            Console.Write(musteri3.MusteriAdi + " " + "İsimli" + " "); MusterininBilgileri.MusteriYasSorgulama(musteri3);
            Console.Write(musteri4.MusteriAdi + " " + "İsimli" + " "); MusterininBilgileri.MusteriYasSorgulama(musteri4);

            Console.WriteLine("\n");


        }
    }
}
