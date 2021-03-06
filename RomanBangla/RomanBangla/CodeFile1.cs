﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ns7.bhaswor;

namespace ns7.bhaswor.LikhonPad
{
    partial class JuktiKendro
    {
        private static BanglaBornoResultSet isSwor1(char romok, char romok_1)
        {
            BanglaBornoResultSet sworoborno = new BanglaBornoResultSet();
            if (romok == 'o')
            {
                if (romok_1 == 'a')
                    return sworoborno.SetVal(2, BanglaBorno.Swor.oa);//ও ো
                else if (romok_1 == 'w')
                    return sworoborno.SetVal(2, BanglaBorno.Swor.ow);//ঔ ৌ
                else
                    return sworoborno.SetVal(1, BanglaBorno.Swor.o);//অ
            }
            else if (romok == 'a')
            {
                return sworoborno.SetVal(1, BanglaBorno.Swor.a);//আ া
            }
            else if (romok == 'i')
            {
                if (romok_1 == 'i')
                    return sworoborno.SetVal(2, BanglaBorno.Swor.ii);//ঈ ী
                else
                    return sworoborno.SetVal(1, BanglaBorno.Swor.i);//ই ি
            }
            else if (romok == 'u')
            {
                if (romok_1 == 'u')
                    return sworoborno.SetVal(2, BanglaBorno.Swor.uu);//ঊ ূ
                else
                    return sworoborno.SetVal(1, BanglaBorno.Swor.u);//উ ু
            }
            else if (romok == 'R')
            {
                if (romok_1 == 'I' || romok_1 == 'i')
                    return sworoborno.SetVal(2, BanglaBorno.Swor.RI);//ঋ ৃ
                else return sworoborno;
            }
            else if (romok == 'e')
            {
                return sworoborno.SetVal(1, BanglaBorno.Swor.e);
            }
            else if (romok == 'O')
            {
                if (romok_1 == 'I' || romok_1 == 'i')
                    return sworoborno.SetVal(2, BanglaBorno.Swor.OI);
                else
                    return sworoborno.SetVal(1, BanglaBorno.Swor.oa);
            }
            else
                return sworoborno;
        }


        private static BanglaBornoResultSet isBorgiio1(char romok, char romok_1)
        {
            BanglaBornoResultSet byanjonborno
                = new BanglaBornoResultSet();
            BanglaBorno.Byanzon x = BanglaBorno.Byanzon._NULL;

            {
                if (romok == 'k')
                    x = BanglaBorno.Byanzon.k;
                else if (romok == 'g')
                    x = BanglaBorno.Byanzon.g;
                else if (romok == 'c')
                    x = BanglaBorno.Byanzon.c;
                else if (romok == 'z')
                    x = BanglaBorno.Byanzon.z;
                else if (romok == 'T')
                    x = BanglaBorno.Byanzon.T;
                else if (romok == 'D')
                    x = BanglaBorno.Byanzon.D;
                else if (romok == 't')
                    x = BanglaBorno.Byanzon.t;
                else if (romok == 'd')
                    x = BanglaBorno.Byanzon.d;
                else if (romok == 'p')
                    x = BanglaBorno.Byanzon.p;
                else if (romok == 'b')
                    x = BanglaBorno.Byanzon.b;
                else return byanjonborno;
            }
            if (romok_1 == 'h')
                byanjonborno.SetVal(2, BanglaBorno.toMohapran(x));
            else
                byanjonborno.SetVal(1, x);

            return byanjonborno;

        }

        private static BanglaBornoResultSet isByanjon1(char romok, char romok_1)
        {
            BanglaBornoResultSet byanjonborno
                = new BanglaBornoResultSet(isBorgiio(romok, romok_1));
            if (byanjonborno.Num > 0)
                return byanjonborno;
            else
            {
                if (romok == 'n')
                {
                    if (romok_1 == '~')
                        return byanjonborno.SetVal(2, BanglaBorno.Byanzon.uno);
                    else if (romok_1 == '_')
                        return byanjonborno.SetVal(2, BanglaBorno.Byanzon._chondrobindu);
                    else
                        return byanjonborno.SetVal(1, BanglaBorno.Byanzon.n);
                }
                else if (romok == 'm')
                {
                    if (romok_1 == '~')
                        return byanjonborno.SetVal(2, BanglaBorno.Byanzon.nio);
                    else
                        return byanjonborno.SetVal(1, BanglaBorno.Byanzon.m);
                }
                else if (romok == 'j')
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.j);
                else if (romok == 'r')
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.r);
                else if (romok == 'l')
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.l);
                else if (romok == 's')
                {
                    if (romok_1 == 'h')
                        return byanjonborno.SetVal(2, BanglaBorno.Byanzon.sh);
                    else if (romok_1 == 's')
                        return byanjonborno.SetVal(2, BanglaBorno.Byanzon.ss);
                    else
                        return byanjonborno.SetVal(1, BanglaBorno.Byanzon.s);
                }
                else if (romok == 'h')
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.h);
                else if (romok == 'R')
                {
                    if (romok_1 == 'h')
                        return byanjonborno.SetVal(2, BanglaBorno.Byanzon.Rh);
                    else
                        return byanjonborno.SetVal(1, BanglaBorno.Byanzon.R);
                }
                else if (romok == 'y')
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.y);

                else return byanjonborno;
            }
        }

      
    }

}