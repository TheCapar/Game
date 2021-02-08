using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri { //Burada müşteri oluşturma amacımız MusteriManager classımızın çalışıp çalışmadığını anlamak için yapmış bulunmaktayız.
                Ad = "Deha",
                SoyAd = "Çapar",
                DogumYılı = 2000,
                TcNo = 123456789
            };
            Oyun oyun = new Oyun {//Burada oyun oluşturma amacımız OyunManager classımızın çalışıp çalışmadığını anlamak için yapmış bulunmaktayız.
                OyunAdi = "CoD",
                OyunFiyati = 99.99,
                KampanyaAdi = "Kdv",
                KampanyaOrani = 15,
                KapmanyaVarmi = true,
                Nakit = true,
                KrediKarti = false,
            };
            Kampanya kampanya = new Kampanya { //Burada kampanya oluşturma amacımız KampanyaManager classımızın çalışıp çalışmadığını anlamak için yapmış bulunmaktayız.
                KampanyaAdi = "Kdv",
                KampanyaOrani = 15,
                KapmanyaVarmi = true,
            };
            Islemler musteriManager = new KampanyaManager();// Burada KampanyaManager yerine MusteriManager yazarsanız musteri manager işlemlerinin de sorunsuz çalıştığını görebilirsiniz.
            musteriManager.Add(musteri,kampanya);
            musteriManager.Delete(musteri,kampanya);
            musteriManager.Update(musteri,kampanya);
            OyunManager oyunManager = new OyunManager(); //Burada ise Oyun satış sisteminin çalışıp çalışmadığını kontrıl etmiş olduk.
            oyunManager.Fiyatlandirma(oyun);
            oyunManager.Ödeme(oyun);
            

        }
    }
}
