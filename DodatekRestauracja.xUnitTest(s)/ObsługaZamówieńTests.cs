using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.Obs³ugaZamównieñ;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class Obs³ugaZamówieñTests
    {
        [Fact]
        public void Odwo³aj_isAdmin_True()
        {
            var oz = new Obs³ugaZamównieñ();

            var res = oz.Odwo³aj(new Sk³adaj¹cy { IsAdmin = true });

            Assert.True(res);
        }
        [Fact]
        public void Odwo³aj_Sk³adaj¹cy_True()
        {
            var sk³adaj¹cy = new Sk³adaj¹cy();
            var oz2 = new Obs³ugaZamównieñ { Wykonuj¹cy = sk³adaj¹cy };

            var res2 = oz2.Odwo³aj(sk³adaj¹cy);

            Assert.True(res2);
        }
        [Fact]
        public void Odwo³aj_NieuprawnionySk³adaj¹cy_False()
        {
            var oz3 = new Obs³ugaZamównieñ { Wykonuj¹cy = new Sk³adaj¹cy()};

            var res3 = oz3.Odwo³aj(new Sk³adaj¹cy());

            Assert.False(res3);
        }
    }
}
