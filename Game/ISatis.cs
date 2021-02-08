using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface ISatis // İnterface kullandım çünkü satışa özel bir özellikti.
    {
        void Fiyatlandirma( Oyun oyun);
        void Ödeme( Oyun oyun);
    }
}
