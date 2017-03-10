using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5zh
{
    public class VizvezetekSzerelo : Mesterember
    {
        private int mTapasztalat;

        public VizvezetekSzerelo(string Nev, int NapiDij, int Tapasztalat) : base(Nev, NapiDij)
        {
            mTapasztalat = Tapasztalat;
        }

        public int Tapasztalat
        {
            get
            {
                return mTapasztalat;
            }

            set
            {
                if (value <= mTapasztalat)
                    throw new Exception("ddd");
                mTapasztalat = value;
            }
        }

        public String MindenAdat()
        {
            StringBuilder sb = new StringBuilder(base.Mindenadat());
            sb.AppendFormat("Tapasztalat:{0}", mTapasztalat.ToString());
            return sb.ToString();
        }

        public override bool MunkatVallal(int Nap)
        {
            if (Nap < 1 || Nap > 29)
                throw new Exception("nemokés");

            if (FoglaltNapok[Nap - 1]
                &&
                FoglaltNapok[Nap]
                &&
                FoglaltNapok[Nap + 1])
            {

                FoglaltNapok[Nap - 1] = false;
                FoglaltNapok[Nap] = false;
                FoglaltNapok[Nap + 1] = false;
                return true;
            }

            return false;
        }
    }
}