using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5zh
{
    public class Burkolo : Mesterember
    {
        private BurkoloSzakteruletTipus mSzakterulet;

        public BurkoloSzakteruletTipus Szakterulet
        {
            get { return mSzakterulet; }
            set
            {
                switch (value)
                {
                    case BurkoloSzakteruletTipus.Belso:
                    case BurkoloSzakteruletTipus.Kulso: break;
                    default: throw new Exception("ddd");
                }
            }
        }

        public Burkolo(string Nev, int NapiDij, BurkoloSzakteruletTipus Szakterulet) : base(Nev, NapiDij)
        {
            this.Szakterulet = Szakterulet;
        }

        public int OsszesSzabadnap()
        {
            int tmp = 0;
            foreach (bool b in FoglaltNapok)
                if (b)
                    tmp++;
            return tmp;
        }

        public override bool MunkatVallal(int Nap)
        {
            if (Nap > 31)
                return false;

            if (FoglaltNapok[Nap] == true)
            {
                FoglaltNapok[Nap] = false;
                return true;
            }

            return false;
        }

        public override String Mindenadat()
        {
            StringBuilder sb = new StringBuilder(base.Mindenadat());
            sb.AppendFormat("Szakterület:{0}", Szakterulet.ToString());
            return sb.ToString();
        }
    }
}