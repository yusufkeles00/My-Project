using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class MusteriManager
	{
		public void Add(Musteri musteriEkle)
		{
			Console.WriteLine("Müşteri Sisteme Eklendi : " + musteriEkle.FirstName + musteriEkle.LastName);
		}

		public void List(Musteri musteriListele)
		{
			Console.WriteLine("Müşteri İstekleri Listelendi : " + musteriListele.Need);
		}

		public void Delete(Musteri musteriSil)
		{
			Console.WriteLine("Müşteri Sistemden Silindi : " + musteriSil.FirstName + musteriSil.LastName + " ID : " + musteriSil.ID);
		}
	}
}
