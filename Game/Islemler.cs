using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
     abstract class Islemler //Burda abstract sınıfı kullandım çünkü kampanya sınıfımda da aynı işlemleri tekrarlıcaktım tekrarlamamak için abstract sınıfa almış bulunmaktayım.
    {
        public abstract void Add(Musteri musteri,Kampanya kampanya);
        public abstract void Update(Musteri musteri, Kampanya kampanya);
        public abstract void Delete(Musteri musteri, Kampanya kampanya);
    }
}
