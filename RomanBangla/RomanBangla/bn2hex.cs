using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.LikhonPad
{
    class htmlUnicode
    {
        public static string CharToHexCode(char unicode)
        {
            uint value = (uint) unicode;
            return "&#x" + value.ToString("X") + ";";
        }
        public static string bn2htmlhex(string bangla)
        {
            char [] input = bangla.ToCharArray();
            StringBuilder outPut = new StringBuilder();
            foreach (char c in input)
            {
                outPut.Append(CharToHexCode(c));
            }
            return outPut.ToString();
        }

        public static string HexCodeChar(char unicode)
        {
            uint value = (uint)unicode;
            return "&#x" + value.ToString("X") + ";";
        }
        public static string htmlhex2bn(string bangla)
        {
            string htmlcode, unicodestr; char unichar;
            for (int i = 2432; i <= 2559; i++ )
            {
                htmlcode = "&#" + i.ToString() + ";";
                unichar = (char)i; 
                bangla = bangla.Replace(htmlcode, unichar.ToString());
            }
            return bangla;
        }
    }
}
