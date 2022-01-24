using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodatekRestauracjaKlasa_Test.KlasaDoTestu
{
    public class ObsługaZamównień
    {
        public Składający Wykonujący { get; set; }
        public bool Odwołaj(Składający składający)
        {
            if (składający.IsAdmin)
                return true;
            if (Wykonujący == składający)
              return true;
            return false;
        }
        public class Składający
        {
            public bool IsAdmin { get; set; }
        }
    }
}
    
