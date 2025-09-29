using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Kullanıcıdan isim alma
        Console.WriteLine("Adinizi Giriniz :");
        string ad = Console.ReadLine();
        Console.WriteLine("Merhaba, " + ad + "!");

        // ___________________________________________________________

        // 2. Toplama işlemi
        Console.WriteLine("Birinci Sayiyi giriniz:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ikinci Sayiyi giriniz:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + toplam);

        // ___________________________________________________________

        // 3. Karşılaştırma işlemleri
        int a = 20, b = 50, c = 100;

        Console.WriteLine("\nRelational Operations in C#");
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));
        Console.WriteLine("b > c  : " + (b > c));
        Console.WriteLine("c < a  : " + (c < a));
        Console.WriteLine("c >= b : " + (c >= b));
        Console.WriteLine("b <= c : " + (b <= c));

        // ___________________________________________________________

        // 4. Faiz hesaplama
        Console.WriteLine("\nBaslangic Miktarini giriniz:");
        double anapara = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Faiz oranini (%) giriniz:");
        double faiz = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.WriteLine("Kac yil hesaplansin?");
        int yil = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= yil; i++)
        {
            anapara += anapara * faiz;
            if (anapara > 10000)
            {
                Console.WriteLine(i + ". Yil sonunda toplam para: " + anapara);
                Console.WriteLine("10000 birim siniri asildigi icin hesaplama durduruldu");
                return;
            }
        }
        Console.WriteLine(yil + ". Yil sonunda toplam para: " + anapara);

        // ___________________________________________________________

        // 5. Notlar dizisi
        int[] notlar = { 45, 67, 89, 32, 76, 90, 55 };

        Console.WriteLine("\nTum Notlar:");
        foreach (int n in notlar)
        {
            Console.WriteLine(n);
        }

        int enYuksek = notlar[0];
        int enDusuk = notlar[0];
        toplam = 0;

        foreach (int n in notlar)
        {
            if (n > enYuksek) enYuksek = n;
            if (n < enDusuk) enDusuk = n;
            toplam += n;
        }

        double ortalama = (double)toplam / notlar.Length;
        Console.WriteLine("\nEn Yuksek Not : " + enYuksek);
        Console.WriteLine("En Dusuk Not   : " + enDusuk);
        Console.WriteLine("Ortalama       : " + ortalama);

        int ortalamaUstuSayisi = 0;
        foreach (int n in notlar)
        {
            if (n > ortalama) ortalamaUstuSayisi++;
        }
        Console.WriteLine("Ortalamanin ustunde olan not sayisi: " + ortalamaUstuSayisi);
    }
}
