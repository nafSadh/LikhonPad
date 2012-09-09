using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.RomanBangla
{
    class Bijoy
    {
        public String unicodeBanglaToBijoy(String str)
        {
            switch(str[1]){
                case 'ক': return "K";
                case 'খ': return "L";
                case 'গ': return "M";
                case 'ঘ': return "N";
                case 'ঙ': return "O";
                case 'চ': return "P";
                case 'ছ': return "Q";
                case 'জ': return "R";
                case 'ঝ': return "S";
                case 'ঞ': return "T";
                case 'ট': return "U";
                case 'ঠ': return "V";
                case 'ড': return "W";
                case 'ঢ': return "X";
                case 'ণ': return "Y";
                case 'ত': return "Z";
                case 'থ': return "_";
                case 'দ': return "`";/**/
                case 'ধ': return "a";
                case 'ন': return "b";
                case 'প': return "c";
                case 'ফ': return "d";
                case 'ব': return "e";
                case 'ভ': return "f";
                case 'ম': return "g";
                case 'য': return "h";
                case 'র': return "i";
            }
            return "";
        }
    }
}
