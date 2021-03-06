using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.ObsługaZamównień;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class ObsługaZamówieńTests
    {
        [Fact]
        public void Odwołaj_isAdmin_True()
        {
            var oz = new ObsługaZamównień();

            var res = oz.Odwołaj(new Składający { IsAdmin = true });

            Assert.True(res);
        }
        [Fact]
        public void Odwołaj_Składający_True()
        {
            var składający = new Składający();
            var oz2 = new ObsługaZamównień { Wykonujący = składający };

            var res2 = oz2.Odwołaj(składający);

            Assert.True(res2);
        }
        [Fact]
        public void Odwołaj_NieuprawnionySkładający_False()
        {
            var oz3 = new ObsługaZamównień { Wykonujący = new Składający()};

            var res3 = oz3.Odwołaj(new Składający());

            Assert.False(res3);
        }
    }
}
