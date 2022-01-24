using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.ObsługaZamównień;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class ObsługaZamówieńTest
    {
        [Fact]
        public void Odwołaj_isAdmin_returnsTrue()
        {
            var oz = new ObsługaZamównień();

            var res = oz.Odwołaj(new User { IsAdmin = true });

            Assert.True(res);
            }
    }
}
