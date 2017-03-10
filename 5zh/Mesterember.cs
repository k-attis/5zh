using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5zh
{
    public abstract class Mesterember
    {
        private String Nev;
        private int NapiDij;
        protected bool[] FoglaltNapok = new bool[31];

        public Mesterember(String Nev, int NapiDij)
        {
            this.Nev = Nev;
            this.NapiDij = NapiDij;
            for (int i = 0; i < 31; i++)
            {
                FoglaltNapok[i] = true;
            }
        }

        public abstract bool MunkatVallal(int Nap);

        public virtual String Mindenadat()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Név:{0} Napidij:{1} ", Nev, NapiDij);
            sb.AppendLine();
            for (int i = 0; i < 31; i++)
            {
                if (FoglaltNapok[i])
                    sb.Append("1,");
                else
                    sb.Append("0,");
            }

            return sb.ToString();
        }
    }
}