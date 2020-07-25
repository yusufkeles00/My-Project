using System;

namespace Üçgen
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;
            char islem;
            Console.WriteLine("Hesap Makinesi");
            Console.Write("1. Sayıyı Girin: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayıyı Girin: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yapacağınız işlemi Girin ('+'=1,'-'=2,'*'=3,'/'=4):");
            islem = Convert.ToChar(Console.ReadLine());
            switch(islem)
            {
                case '1':
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case '2':
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case '3':
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case '4':
                    Console.WriteLine(sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine("Hatalı İşlem!!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
