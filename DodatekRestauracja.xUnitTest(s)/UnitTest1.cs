using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.Obs³ugaZamównieñ;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class Obs³ugaZamówieñTest
    {
        [Fact]
        public void Odwo³aj_isAdmin_returnsTrue()
        {
            var oz = new Obs³ugaZamównieñ();

            var res = oz.Odwo³aj(new User { IsAdmin = true });

            Assert.True(res);
            }
    }
}
