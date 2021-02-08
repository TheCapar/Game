using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IDogrulama //İnterface kullandım çünkü müşteriye ait özellikti yani müşteri harici kullanamayacaktı.
    {
        void Dogrulama(Musteri musteri);
       
    }
}
