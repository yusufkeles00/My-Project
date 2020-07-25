using System;

namespace Vücut_Kitle_İndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            double boy, kilo, vki;
            Console.WriteLine("Vücut Kitle Endeksi Programına Hoşgeldiniz");
            Console.Write("Boyunuzu Giriniz (1,75 şeklinde): ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz(75 şeklinde): ");
            kilo = Convert.ToDouble(Console.ReadLine());
            vki = kilo / (boy * boy);
            if (vki > 0 && vki <= 18.4)
            {
                Console.Write("Vücut Kitle İndeksiniz: {0} Zayıf", vki);
            }
            else if (vki > 18.4 && vki <= 24.9)
            {
                Console.Write("Vücut Kitle İndeksiniz: {0} Normal", vki);
            }
            else if (vki > 24.9 && vki <= 29.9)
            {
                Console.Write("Vücut Kitle İndeksiniz: {0} Kilolu", vki);
            }
            else if (vki > 29.9 && vki <= 34.9)
            {
                Console.Write("Vücut Kitle İndeksiniz: {0} 1.Derece Obez!");
            }
            else if (vki > 34.9 && vki <= 44.9)
            {
                Console.Write("Vücut Kitle İndeksi: {0} 2.Derece Obez!!");
            }
            else if(vki > 44.9)
            {
                Console.Write("Vücut Kitle İndeksi: {0} Aşırı Obez!!!");
            }
            else
            {
                Console.Write("Tekrar Deneyin!!!");
            }
            Console.ReadKey();
        }
    }
}
