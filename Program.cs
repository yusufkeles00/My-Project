using System;

namespace deneme_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilensayi;
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 11);
            int kalanhak = 3;
            Console.WriteLine("!!!Sayi Tahmin Programına Hoşgeldiniz!!!");
            do
            {
                Console.Write("Tahmininizi Girin (1-10 arası): ");
                girilensayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == girilensayi)
                {
                    Console.WriteLine("Doğru Tahmin!!!");

                }
                else
                {
                    kalanhak--;
                    Console.WriteLine("Yanlış Tahmin Tekrar Deneyin! \n(Kalan Hak: {0})", kalanhak);
                }
            } while ((sayi != girilensayi) && (kalanhak > 0));
            Console.WriteLine("Oyunu Kazanamadınız!");
            Console.ReadKey();
        }
    }
}