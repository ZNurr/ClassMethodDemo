using ClassMethodDemo;


Musteri musteri1 = new Musteri();
musteri1.Tc = 123456789101;
musteri1.Id = 1;
musteri1.MusteriAdi = "Nur";
musteri1.MusteriSoyadi = "Yıldırım";


Musteri musteri2 = new Musteri();
musteri2.Tc = 138464575418;
musteri2.Id = 2;
musteri2.MusteriAdi = "Yasir";
musteri2.MusteriSoyadi = "Shogun";

MusteriManager musterimanager= new MusteriManager();
musterimanager.Add(musteri1);
musterimanager.List(musteri1);
musterimanager.Delete(musteri1);    
musterimanager.Update(musteri1);

Console.WriteLine("-------------------------------------------------------------");

musterimanager.Add(musteri2);
musterimanager.List(musteri2);
musterimanager.Delete(musteri2);
musterimanager.Update(musteri2);

Console.WriteLine("-------------------------------------------------------------");


Musteri[] musteriler = new Musteri[2] {musteri1,musteri2};

foreach(var musteri in musteriler)
{
    musterimanager.Delete(musteri);
    musterimanager.Add(musteri);
    musterimanager.Update(musteri);
    musterimanager.List(musteri);
}
Console.WriteLine("-------------------------------------------------------------");
