using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.Obs�ugaZam�wnie�;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class Obs�ugaZam�wie�Test
    {
        [Fact]
        public void Odwo�aj_isAdmin_returnsTrue()
        {
            var oz = new Obs�ugaZam�wnie�();

            var res = oz.Odwo�aj(new User { IsAdmin = true });

            Assert.True(res);
            }
    }
}
