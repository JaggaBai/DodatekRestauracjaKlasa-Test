using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.ObsługaZamównień;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class ObsługaZamówieńTests
    {
        [Fact]
        public void Odwołaj_isAdmin_returnsTrue()
        {
            var oz = new ObsługaZamównień();

            var res = oz.Odwołaj(new User { IsAdmin = true });

            Assert.True(res);
        }
        [Fact]
        public void Odwołaj_User_returnsTrue()
        {
            var user = new User();
            var oz2 = new ObsługaZamównień { Wykonujący = user };

            var res2 = oz2.Odwołaj(user);

            Assert.True(res2);
        }
        [Fact]
        public void Odwołaj_NieuprawnionyUser_returnsFalse()
        {
            var oz3 = new ObsługaZamównień { Wykonujący = new User()};

            var res3 = oz3.Odwołaj(new User());

            Assert.False(res3);
        }
    }
}
