using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.LikhonPad
{
    class Brahmi
    {
        public static char bn2brah(char bn)
        {
            if (util.isBangla(bn)) return (char)(bn + 0x10680);
            else return bn;
        }


        public static string bn2brah(string bn)
        {
            char[] input = bn.ToCharArray();
            StringBuilder outPut = new StringBuilder();
            foreach (char c in input)
            {
                outPut.Append(bn2brah(c));
            }
            return outPut.ToString();
        }
    }
}
