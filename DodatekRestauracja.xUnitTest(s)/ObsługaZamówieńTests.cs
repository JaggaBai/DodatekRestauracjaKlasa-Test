using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.Obs�ugaZam�wnie�;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class Obs�ugaZam�wie�Tests
    {
        [Fact]
        public void Odwo�aj_isAdmin_returnsTrue()
        {
            var oz = new Obs�ugaZam�wnie�();

            var res = oz.Odwo�aj(new User { IsAdmin = true });

            Assert.True(res);
        }
        [Fact]
        public void Odwo�aj_User_returnsTrue()
        {
            var user = new User();
            var oz2 = new Obs�ugaZam�wnie� { Wykonuj�cy = user };

            var res2 = oz2.Odwo�aj(user);

            Assert.True(res2);
        }
        [Fact]
        public void Odwo�aj_NieuprawnionyUser_returnsFalse()
        {
            var oz3 = new Obs�ugaZam�wnie� { Wykonuj�cy = new User()};

            var res3 = oz3.Odwo�aj(new User());

            Assert.False(res3);
        }
    }
}
