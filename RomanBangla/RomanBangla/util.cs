using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.LikhonPad
{
    class util
    {
        public static bool isBangla(char c)
        {
            if (0x0980 <= c && c <= 0x09ff) return true;
            else return false;
        }
        
        public static bool isDevanagari(char c)
        {
            if (0x0900 <= c && c <= 0x097f) return true;
            else return false;
        }
    }
}