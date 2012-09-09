using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.LikhonPad
{
    class Bn2En
    {
        public static string bengaliTranslit(char bn)
        {
            switch (bn)
            {
                case 'ক': return "k";
                case 'খ': return "kh";
                case 'গ': return "g";
                case 'ঘ': return "gh";
                case 'ঙ': return "ng";
                case 'চ': return "c";
                case 'ছ': return "ch";
                case 'জ': return "z";
                case 'ঝ': return "zh";
                case 'ঞ': return "n";
                case 'ট': return "T";
                case 'ঠ': return "Th";
                case 'ড': return "D";
                case 'ঢ': return "Dh";
                case 'ণ': return "N";
                case 'ত': return "t";
                case 'থ': return "th";
                case 'দ': return "d";
                case 'ধ': return "dh";
                case 'ন': return "n";
                case 'প': return "p";
                case 'ফ': return "ph";
                case 'ব': return "b";
                case 'ভ': return "bh";
                case 'ম': return "m";
                case 'য': return "j";
                case 'র': return "r";
                case 'ল': return "l";
                case 'শ': return "sh";
                case 'ষ': return "ss";
                case 'স': return "s";
                case 'হ': return "h";
                case 'ড়': return "R";
                case 'ঢ়': return "Rh";
                case 'য়': return "y";
                case 'ৎ': return "t";
                case 'ং': return "ng";
                case 'ঃ': return ":";
                case 'ঁ': return "~";
                    
                case '্': return "";
                case 'অ': return "o";
                case 'আ': 
                case 'া': return "a";
                case 'ই': 
                case 'ি': return "i";
                case 'ঈ': 
                case 'ী': return "I";
                case 'উ': 
                case 'ু': return "u";
                case 'ঊ': 
                case 'ূ': return "U";
                case 'ঋ': 
                case 'ৃ': return "ri";
                case 'এ': 
                case 'ে': return "e";
                case 'ঐ': 
                case 'ৈ': return "oi";
                case 'ও': 
                case 'ো': return "O";
                case 'ঔ': 
                case 'ৌ': return "ou";

                default: return bn.ToString();
            }
        }

        public static bool isSwor(char bn)
        {
            if (0x0984 < bn && bn <= 0x0994) return true;
            else return false;
        }
        public static bool isSworKar(char bn)
        {
            if (0x09bd <= bn && bn <= 0x09CD) return true;
            else return false;
        }
        public static bool isBanjon(char bn)
        {
            if (0x0995 <= bn && bn <= 0x09b9) return true;
            else if (0x09dc <= bn && bn <= 0x09df) return true;
            else return false;
        }
        public static string bengaliTranslit(string bangla)
        {
            char[] input = bangla.ToCharArray();
            StringBuilder outPut = new StringBuilder();
            char prev,curr;
            int max = input.Length; 
            if (max > 0)
            {
            outPut.Append(bengaliTranslit(input[0]));

                for (int i = 1; i < max; i++)
                {
                    prev = input[i - 1];
                    curr = input[i];
                    if (isBanjon(curr) && isBanjon(prev))
                        outPut.Append("o");
                    outPut.Append(bengaliTranslit(curr));
                }
            }
            return outPut.ToString();
        }
    }
}
