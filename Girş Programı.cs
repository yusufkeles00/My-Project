using System;

namespace Deneme1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string defkullanici = "yusufkeles";
            int defsifre = 1234;
            int kalanhak = 3;
            string kullanici;
            int sifre;
            while (kalanhak != 0)
            {
                Console.Write("Kullanıcı Adınızı Giriniz: ");
                kullanici = Console.ReadLine();
                Console.Write("Şifrenizi Giriniz: ");
                sifre = Convert.ToInt32(Console.ReadLine());
                if (defkullanici == kullanici && defsifre == sifre)
                {
                    Console.WriteLine("Giriş Başarılı! Hoşgeldin {0}", defkullanici);
                    break;
                }
                else
                {
                    kalanhak--;
                    Console.WriteLine("Şifre Yanlış!!! Kalan Deneme Hakkı: {0}", kalanhak);
                }
            }
            Console.ReadKey();
        }
    }
}
