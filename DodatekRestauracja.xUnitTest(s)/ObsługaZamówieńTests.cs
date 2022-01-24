using DodatekRestauracjaKlasa_Test.KlasaDoTestu;
using System;
using Xunit;
using static DodatekRestauracjaKlasa_Test.KlasaDoTestu.Obs³ugaZamównieñ;

namespace DodatekRestauracja.xUnitTest_s_
{
    public class Obs³ugaZamówieñTests
    {
        [Fact]
        public void Odwo³aj_isAdmin_returnsTrue()
        {
            var oz = new Obs³ugaZamównieñ();

            var res = oz.Odwo³aj(new User { IsAdmin = true });

            Assert.True(res);
        }
        [Fact]
        public void Odwo³aj_User_returnsTrue()
        {
            var user = new User();
            var oz2 = new Obs³ugaZamównieñ { Wykonuj¹cy = user };

            var res2 = oz2.Odwo³aj(user);

            Assert.True(res2);
        }
        [Fact]
        public void Odwo³aj_NieuprawnionyUser_returnsFalse()
        {
            var oz3 = new Obs³ugaZamównieñ { Wykonuj¹cy = new User()};

            var res3 = oz3.Odwo³aj(new User());

            Assert.False(res3);
        }
    }
}
