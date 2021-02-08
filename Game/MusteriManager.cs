using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class MusteriManager :Islemler,IDogrulama
    {
        
        public override void Add(Musteri musteri, Kampanya kampanya)
        {
           Console.WriteLine(musteri.Ad + " Tebrikler Sisteme Başarıyla Kayıt Oldunuz.");
        }

        public override void Delete(Musteri musteri, Kampanya kampanya)
        {
            Console.WriteLine(musteri.Ad+ " Kaydınız Sistemden Başarıyla Silindi.");
        }


        public void Dogrulama(Musteri musteri) //Burada ise TcNo kullanarak doğrulama yapıyoruz.
        {
            Console.WriteLine("Musterinin Tcsini Doğrulanmıştır.");
            Console.WriteLine("Doğrulanan Musteri Tcsi:" + musteri.TcNo);
        }

        public override void Update(Musteri musteri, Kampanya kampanya)
        {
            Console.WriteLine(musteri.TcNo + " Kaydınız Başarıyla Güncellenmiştir.");
        }
    }
}
