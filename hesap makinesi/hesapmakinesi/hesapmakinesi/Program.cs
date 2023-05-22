using System;

namespace sınavvvv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hesap topla = new hesap();
            hesap cık = new hesap();
            hesap car = new hesap();
            hesap bo = new hesap();
            hesap mo = new hesap();
            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi1 + " + " + sayi2 + " = " + topla.toplam(sayi1, sayi2));
            Console.WriteLine(sayi1 + " - " + sayi2 + " = " + cık.cıkar(sayi1, sayi2));
            Console.WriteLine(sayi1 + " * " + sayi2 + " = " + car.carp(sayi1, sayi2));
            Console.WriteLine(sayi1 + " / " + sayi2 + " = " + bo.bol(sayi1, sayi2));
            Console.WriteLine(sayi1 + " % " + sayi2 + " = " + mo.mod(sayi1, sayi2));
        }
    }
    class hesap
    {
        public int toplam(int sayi, int sayi2)
        {
            int sonuc = sayi + sayi2;
            return sonuc;
        }
        public int cıkar(int sayi, int sayi2)
        {
            int sonuc = sayi - sayi2;
            return sonuc;
        }
        public int carp(int sayi, int sayi2)
        {
            int sonuc = sayi * sayi2;
            return sonuc;
        }
        public int bol(int sayi, int sayi2)
        {
            int sonuc = sayi / sayi2;
            return sonuc;
        }
        public int mod(int sayi, int sayi2)
        {
            int sonuc = sayi % sayi2;
            return sonuc;
        }
    }
}
