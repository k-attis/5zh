using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5zh
{
    public class Teszt
    {
        private Mesterember[] MesterEmberek = new Mesterember[6];

        public Teszt()
        {
            MesterEmberek[0] = new Burkolo("Tapéta Lajos", 60000, BurkoloSzakteruletTipus.Belso);
            MesterEmberek[1] = new VizvezetekSzerelo("Megszer Elek", 12000, 3);
            MesterEmberek[2] = new Burkolo("Vakolat Péter", 50000, BurkoloSzakteruletTipus.Kulso);
            MesterEmberek[3] = new VizvezetekSzerelo("Víz Elek", 15000, 5);
            MesterEmberek[4] = new Burkolo("Ersz János", 30000, BurkoloSzakteruletTipus.Kulso);
        }
    }
}