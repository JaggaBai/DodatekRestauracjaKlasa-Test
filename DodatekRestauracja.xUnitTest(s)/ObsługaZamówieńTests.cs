using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.Obs�ugaZam�wnie�;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class Obs�ugaZam�wie�Tests
    {
        [Fact]
        public void Odwo�aj_isAdmin_True()
        {
            var oz = new Obs�ugaZam�wnie�();

            var res = oz.Odwo�aj(new Sk�adaj�cy { IsAdmin = true });

            Assert.True(res);
        }
        [Fact]
        public void Odwo�aj_Sk�adaj�cy_True()
        {
            var sk�adaj�cy = new Sk�adaj�cy();
            var oz2 = new Obs�ugaZam�wnie� { Wykonuj�cy = sk�adaj�cy };

            var res2 = oz2.Odwo�aj(sk�adaj�cy);

            Assert.True(res2);
        }
        [Fact]
        public void Odwo�aj_NieuprawnionySk�adaj�cy_False()
        {
            var oz3 = new Obs�ugaZam�wnie� { Wykonuj�cy = new Sk�adaj�cy()};

            var res3 = oz3.Odwo�aj(new Sk�adaj�cy());

            Assert.False(res3);
        }
    }
}
