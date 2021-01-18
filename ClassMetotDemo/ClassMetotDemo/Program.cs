using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri musteri = new Musteri();
			musteri.ID = 123456789;
			musteri.FirstName = " Yusuf";
			musteri.LastName = " Keleş";
			musteri.Need = "Ayakkabı, Elbise";


			Musteri[] musteriler = new Musteri[] { musteri };

			foreach (Musteri musteriLoop in musteriler)
			{
				Console.WriteLine("----------- ! 1. Müşteri Bilgileri ! -----------");
				Console.WriteLine("ID : " + musteriLoop.ID);
				Console.WriteLine("İsim : " + musteriLoop.FirstName);
				Console.WriteLine("Soyİsim : " + musteriLoop.LastName);
				Console.WriteLine("İstekler : " + musteriLoop.Need);
			}

			Console.WriteLine("-------------- ! İşlemler ! -------------");
			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Add(musteri);
			musteriManager.List(musteri);
			musteriManager.Delete(musteri);

		}
	}
}
