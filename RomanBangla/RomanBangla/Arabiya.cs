using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ns7.bhaswor;

namespace ns7.bhaswor.LikhonPad
{
    enum harf
    {
        /* e    */     hamza = 0X0621,
        /* a    */     alef =  0X0627,
        /* b    */     beh,
        /* t`   */     teh_marbuta,
        /* t    */     teh,
        /* c    */     thm,
        /* J    */     jeem,
        /* H    */     hah,
        /* K    */     khah,
        /* d    */     dal,
        /* j    */     jhal,
        /* r    */     reh,
        /* z    */     zain,
        /* s    */     seen,
        /* x    */     xheen,
        /* S    */     swad,
        /* D    */     dwad,
        /* T    */     twah,
        /* Z    */     zwah,
        /* E    */     ain,
        /* G    */     ghain,
        /*      */     keheh_2,
        /*      */     keheh_3,
        /*      */     yeh_azeri,
        /*      */     yeh_farsi_2,
        /*      */     yeh_farsi_3,
        /*      */     tatweel,
        /* f    */     fef =    0X0641,
        /* q    */     qaf,
        /* k    */     kaf,
        /* l    */     lam,
        /* m    */     meem,
        /* n    */     noon,
        /* h    */     he,
        /* w    */     waw,
        /* Y    */     yeh_maksura,
        /* y    */     yeh,
    }

    class RomamArabic
    {
        private static char toArabChar(harf h){
            return (char)((int)h);
        }
        public static string RomanToArabic(string romok)
        {
            char[] array = romok.ToCharArray();
            StringBuilder arabicSB = new StringBuilder();

            int i = 0;

            while (i< array.Length)
            {
                switch (array[i])
                {
                    case 'a': arabicSB.Append(toArabChar(harf.alef)); break;
                    case 'b': arabicSB.Append(toArabChar(harf.beh)); break;
                    case 't': arabicSB.Append(toArabChar(harf.teh)); break;
                    case 'c': arabicSB.Append(toArabChar(harf.thm)); break;
                    case 'J': arabicSB.Append(toArabChar(harf.jeem)); break;
                    case 'H': arabicSB.Append(toArabChar(harf.hah)); break;
                    case 'K': arabicSB.Append(toArabChar(harf.khah)); break;
                    case 'd': arabicSB.Append(toArabChar(harf.dal)); break;
                    case 'j': arabicSB.Append(toArabChar(harf.jhal)); break;
                    case 'r': arabicSB.Append(toArabChar(harf.reh)); break;
                    case 'z': arabicSB.Append(toArabChar(harf.zain)); break;
                    case 's': arabicSB.Append(toArabChar(harf.seen)); break;
                    case 'x': arabicSB.Append(toArabChar(harf.xheen)); break;
                    case 'S': arabicSB.Append(toArabChar(harf.swad)); break;
                    case 'D': arabicSB.Append(toArabChar(harf.dwad)); break;
                    case 'T': arabicSB.Append(toArabChar(harf.twah)); break;
                    case 'Z': arabicSB.Append(toArabChar(harf.zwah)); break;
                    case 'E': arabicSB.Append(toArabChar(harf.ain)); break;
                    case 'G': arabicSB.Append(toArabChar(harf.ghain)); break;
                    case 'f': arabicSB.Append(toArabChar(harf.fef)); break;
                    case 'q': arabicSB.Append(toArabChar(harf.qaf)); break;
                    case 'k': arabicSB.Append(toArabChar(harf.kaf)); break;
                    case 'l': arabicSB.Append(toArabChar(harf.lam)); break;
                    case 'm': arabicSB.Append(toArabChar(harf.meem)); break;
                    case 'n': arabicSB.Append(toArabChar(harf.noon)); break;
                    case 'w': arabicSB.Append(toArabChar(harf.waw)); break;
                    case 'e': arabicSB.Append(toArabChar(harf.hamza)); break;
                    case 'h': arabicSB.Append(toArabChar(harf.he)); break;
                    case 'y': arabicSB.Append(toArabChar(harf.yeh)); break;
                    case 'Y': arabicSB.Append(toArabChar(harf.yeh_maksura)); break;
                    default: arabicSB.Append(array[i]); break;
                }
                i++;
            }
            return arabicSB.ToString();
        }
    }
}