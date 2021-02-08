using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class KampanyaManager : Islemler
    {
        public override void Add(Musteri musteri, Kampanya kampanya)
        {
            Console.WriteLine("Eklenen Kampanya Adı: " + kampanya.KampanyaAdi);
            Console.WriteLine("Eklenen Kampanya Oranı: " + kampanya.KampanyaOrani);
        }
        public override void Delete(Musteri musteri, Kampanya kampanya)
        {
            Console.WriteLine("Kapmanya Adına Göre Silim İşlemi Yapılmıştır. ");
            Console.WriteLine("Silinen Kakpanya Adı: " + kampanya.KampanyaAdi );
            Console.WriteLine("Silinen Kampanya Oranı " + kampanya.KampanyaOrani);
        }

        public override void Update(Musteri musteri, Kampanya kampanya)
        {
            Console.WriteLine("Güncellenicek Kampanya Adını Giriniz: " + kampanya.KampanyaAdi);
            Console.WriteLine("Güncellediğiniz Yeni Kampanya Adi: " + kampanya.KampanyaAdi);
            Console.WriteLine("Güncellenicek Kampanya Oranini Giriniz: " + kampanya.KampanyaOrani);
            Console.WriteLine("Güncellediğiniz Yeni Kampanya Orani: " + kampanya.KampanyaOrani);
        }

    }
}
