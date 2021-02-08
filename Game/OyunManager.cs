using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class OyunManager : ISatis
    {
       

        public void Fiyatlandirma( Oyun oyun)
        {
            double toplam = oyun.OyunFiyati - oyun.KampanyaOrani;
            Console.WriteLine("Satın Aldığınız Oyunun Adı: " + oyun.OyunAdi);
            Console.WriteLine("Oyunun Orjinal Fiyatı: " + oyun.OyunFiyati);
            Console.WriteLine("Kampanyanız Var mı?: " + oyun.KapmanyaVarmi);
            if (oyun.KapmanyaVarmi == true)
            {
                Console.WriteLine( "Kampanya Adi: " + oyun.KampanyaAdi);
                Console.WriteLine("Kampanya Orani: " + oyun.KampanyaOrani);
                
                Console.WriteLine("Kampanyaya Özel Fiyat: " + toplam);
            }
            else
            {
                Console.WriteLine("Kampanyanız Bulunmamaktadır.");
            }
            
        }

        public void Ödeme( Oyun oyun)
        {
            double toplam = oyun.OyunFiyati - oyun.KampanyaOrani;
            Console.WriteLine("Ödeme Yöntemi Seçiniz: " );
            if(oyun.Nakit == true ){
                Console.WriteLine("Nakit İle Ödemeyi Seçtiniz.");
                Console.WriteLine("Ödenecek Tutar: " + toplam);
            }
            else
            {
                Console.WriteLine("Kredi Kartı İle Ödemeye Yöntemi Seçtiniz.");
                Console.WriteLine("Ödenecek Tutar: " + toplam);
            }
            
        }
    }
}
