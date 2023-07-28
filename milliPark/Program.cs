
using System;
using System.Collections.Generic;
using System.IO;

class MilliPark
{
    public string MilliPark_Adı { get; set; }
    public List<string> İl_Adları { get; set; }
    public int İlan_Yılı { get; set; }
    public double Yüzölçümü { get; set; }

    public MilliPark(string ad, List<string> iller, int yıl, double yüzölçüm)
    {
        MilliPark_Adı = ad;
        İl_Adları = iller;
        İlan_Yılı = yıl;
        Yüzölçümü = yüzölçüm;
    }
}

class Program
{
    static void Main()
    {
        List<MilliPark>[] milliParkDizisi = new List<MilliPark>[2]; // 2 elemanlı bir Generic List dizisi
        milliParkDizisi[0] = new List<MilliPark>(); // 0. elemanı oluştur
        milliParkDizisi[1] = new List<MilliPark>(); // 1. elemanı oluştur

        // Dosyadan verileri okuyarak MilliPark nesnelerini oluşturunuz.
        try
        {
            using (StreamReader sr = new StreamReader("milli.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string ad = parts[0];
                    List<string> iller = new List<string>(parts[1].Split(','));
                    int yıl = int.Parse(parts[2]);
                    double yüzölçüm = double.Parse(parts[3]);

                    MilliPark milliPark = new MilliPark(ad, iller, yıl, yüzölçüm);

                    if (yüzölçüm < 15000)
                    {
                        milliParkDizisi[0].Add(milliPark);
                    }
                    else
                    {
                        milliParkDizisi[1].Add(milliPark);
                    }
                }
            }

            // Dizideki her bir listedeki bilgilerin tümünü ekrana yazdıran metodu çağırın ve toplam yüzölçümünü hesaplayıp yazdırın
            foreach (MilliPark milliPark in milliParkDizisi[0])
            {
                PrintAndCalculate(milliPark);
            }

            foreach (MilliPark milliPark in milliParkDizisi[1])
            {
                PrintAndCalculate(milliPark);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Dosya okuma hatası: " + e.Message);
        }

        Console.ReadKey();
    }

    static void PrintAndCalculate(MilliPark milliPark)
    {
        Console.WriteLine($"Milli Park Adı: {milliPark.MilliPark_Adı}");
        Console.WriteLine("Bulunduğu İller:");
        foreach (string il in milliPark.İl_Adları)
        {
            Console.WriteLine(il);
        }
        Console.WriteLine($"İlan Yılı: {milliPark.İlan_Yılı}");
        Console.WriteLine($"Yüzölçümü: {milliPark.Yüzölçümü} hektar");
        Console.WriteLine();
    }
}
