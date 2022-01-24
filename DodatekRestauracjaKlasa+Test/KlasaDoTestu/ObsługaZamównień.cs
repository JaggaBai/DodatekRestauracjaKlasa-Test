using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodatekRestauracjaKlasa_Test.KlasaDoTestu
{
    public class ObsługaZamównień
    {
        public User Wykonujący { get; set; }
        public bool Odwołaj(User user)
        {
            if (user.IsAdmin)
                return true;
           
            return false;
        }
        public class User
        {
            public bool IsAdmin { get; set; }
        }
    }
}
    
