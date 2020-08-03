using System;
using System.Timers;

namespace Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            int botp = 0;
            int playerp = 0;
        basadon:
            Console.Clear();
            Console.WriteLine("  Taş Kağıt Makas Oyunu");
            Console.WriteLine("--------------------------");
            Random sayi = new Random();
            int rnd = sayi.Next(1, 4);
            Console.WriteLine(rnd);
            Console.WriteLine("[1]Taş\n[2]Kağıt\n[3]Makas");//1: Taş, 2: Kağıt, 3: Makas
            Console.Write("Seçim: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1 && rnd == 1)
            {
                Console.WriteLine("Taş : Taş\nBerabere...");
                botp += 1;
                playerp += 1;
                goto tekrar;
            }
            else if (secim == 1 && rnd == 2)
            {
                Console.WriteLine("Taş : Kağıt\nKaybettin!!!");
                botp += 3;
                goto tekrar;
            }
            else if (secim == 1 && rnd == 3)
            {
                Console.WriteLine("Taş : Makas\nKazandın!!!");
                playerp += 3;
                goto tekrar;
            }
            else if (secim == 2 && rnd == 2)
            {
                Console.WriteLine("Kağıt : Kağıt\nBerabere...");
                botp += 1;
                playerp += 1;
                goto tekrar;
            }
            else if (secim == 2 && rnd == 1)
            {
                Console.WriteLine("Kağıt : Taş\nKazandın!!!");
                playerp += 3;
                goto tekrar;
            }
            else if (secim == 2 && rnd == 3)
            {
                Console.WriteLine("Kağıt : Makas\nKaybettin!!!");
                botp += 3;
                goto tekrar;
            }
            else if (secim == 3 && rnd == 1)
            {
                Console.WriteLine("Makas : Taş\nKaybettin!!!");
                botp += 3;
                goto tekrar;
            }
            else if (secim == 3 && rnd == 2)
            {
                Console.WriteLine("Makas : Kağıt\nKazandın!!!");
                playerp += 3;
                goto tekrar;
            }
            else if (secim == 3 && rnd == 3)
            {
                Console.WriteLine("Makas : Makas\nBerabere...");
                botp += 1;
                playerp += 1;
                goto tekrar;
            }
        tekrar:
            Console.Write("Tekrar Oynamak İster misiniz?(E/H): ");
            char cevap = Convert.ToChar(Console.ReadLine());
            if (cevap == 'E' || cevap == 'e')
            {
                goto basadon;
            }
            else if (cevap == 'H' || cevap == 'h')
            {
                Console.WriteLine("Oyun Sona Erdi.\nPuanalar: Sen:{0}  ,  Rakip:{1}", playerp, botp);
            }

            Console.ReadKey();
        }
    }
}
