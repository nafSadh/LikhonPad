using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ns7.bhaswor;

namespace ns7.bhaswor.Greek
{
    enum greekLetter
    {
        /* α a */        alpha = 0X03B1,
        /* β b */        beta,
        /* υ g */        gamma,
        /* δ d */        delta,
        /* ε e */        epsilon,
        /* ζ z */        zeta,
        /* η h */        eta,
        /* θ q */        theta,
        /* ι i */        iota,
        /* κ k */        kappa,
        /* λ l */        lamda,
        /* μ m */        mu,
        /* ν n */        nu,
        /* ξ c */        xi,
        /* ο o */        omicron,
        /* π p */        pi,
        /* ρ r */        rho,
        /* ς s */        sigma_final,
        /* σ s */        sigma,
        /* τ t */        tau,
        /* υ u */        upsilon,
        /* φ f */        phi,
        /* χ x */        chi,
        /* ψ y */        psi,
        /* ω w */        omega,
        /* `f  */        digamma = 0X03DD,
        /* `q  */        qoppa = 0x03D9,
        /* `m  */        san = 0x03FB,
        /* `c  */        sampi = 0X03E1,
        /* `s  */        stigma = 0x03DB,
        /* `p  */        sho = 0x03F8,
        /* `h  */        heta = 0x0371,
        /* `k  */        koppa = 0x03DF,
        /* `t  */        sampi_archaic = 0x0373,
        /* `n  */        pamphylian = 0x0377,
    }

    class RomanGreek
    {
        private static char toGreekChar(greekLetter gl, char romanLetter)
        {
            char c = (char)((int)gl);
            if (Char.IsUpper(romanLetter))
            {
                return (char)(c - 32);
            }
            return c;
        }
        private static char toGreekOther(greekLetter gl, char romanLetter)
        {
            char c = (char)((int)gl);
            if (Char.IsUpper(romanLetter))
            {
                return (char)(c - 1);
            }
            return c;
        }

        public static string RomanToGreek(string roman)
        {
            char[] array = roman.ToCharArray();
            int i = 0;
            StringBuilder greekSB = new StringBuilder();
            char c = ' ';
            while (i < array.Length)
            {
                c = array[i++];
                switch (c)
                {
                    case 'A':
                    case 'a':
                        greekSB.Append(toGreekChar(greekLetter.alpha, c)); break;
                    case 'B':
                    case 'b':
                        greekSB.Append(toGreekChar(greekLetter.beta, c)); break;
                    case 'G':
                    case 'g':
                        greekSB.Append(toGreekChar(greekLetter.gamma, c)); break;
                    case 'D':
                    case 'd':
                        greekSB.Append(toGreekChar(greekLetter.delta, c)); break;
                    case 'E':
                    case 'e':
                        greekSB.Append(toGreekChar(greekLetter.epsilon, c)); break;
                    case 'Z':
                    case 'z':
                        greekSB.Append(toGreekChar(greekLetter.zeta, c)); break;
                    case 'H':
                    case 'h':
                        greekSB.Append(toGreekChar(greekLetter.eta, c)); break;
                    case 'Q':
                    case 'q':
                        greekSB.Append(toGreekChar(greekLetter.theta, c)); break;
                    case 'I':
                    case 'i':
                        greekSB.Append(toGreekChar(greekLetter.iota, c)); break;
                    case 'K':
                    case 'k':
                        greekSB.Append(toGreekChar(greekLetter.kappa, c)); break;
                    case 'L':
                    case 'l':
                        greekSB.Append(toGreekChar(greekLetter.lamda, c)); break;
                    case 'M':
                    case 'm':
                        greekSB.Append(toGreekChar(greekLetter.mu, c)); break;
                    case 'N':
                    case 'n':
                        greekSB.Append(toGreekChar(greekLetter.nu, c)); break;
                    case 'C':
                    case 'c':
                        greekSB.Append(toGreekChar(greekLetter.xi, c)); break;
                    case 'O':
                    case 'o':
                        greekSB.Append(toGreekChar(greekLetter.omicron, c)); break;
                    case 'P':
                    case 'p':
                        greekSB.Append(toGreekChar(greekLetter.pi, c)); break;
                    case 'R':
                    case 'r':
                        greekSB.Append(toGreekChar(greekLetter.rho, c)); break;
                    case 'S':
                    case 's':
                        greekSB.Append(toGreekChar(greekLetter.sigma, c)); break;
                    case 'T':
                    case 't':
                        greekSB.Append(toGreekChar(greekLetter.tau, c)); break;
                    case 'U':
                    case 'u':
                        greekSB.Append(toGreekChar(greekLetter.upsilon, c)); break;
                    case 'F':
                    case 'f':
                        greekSB.Append(toGreekChar(greekLetter.phi, c)); break;
                    case 'X':
                    case 'x':
                        greekSB.Append(toGreekChar(greekLetter.chi, c)); break;
                    case 'Y':
                    case 'y':
                        greekSB.Append(toGreekChar(greekLetter.psi, c)); break;
                    case 'W':
                    case 'w':
                        greekSB.Append(toGreekChar(greekLetter.omega, c)); break;
                    case '`':
                        {
                            if ((i) < array.Length) c = array[i++];
                            else break;
                            switch (c)
                            {
                                case 'F':
                                case 'f':
                                    greekSB.Append(toGreekOther(greekLetter.digamma, c)); break;
                                case 'Q':
                                case 'q':
                                    greekSB.Append(toGreekOther(greekLetter.qoppa, c)); break;
                                case 'M':
                                case 'm':
                                    greekSB.Append(toGreekOther(greekLetter.san, c)); break;
                                case 'C':
                                case 'c':
                                    greekSB.Append(toGreekOther(greekLetter.sampi, c)); break;
                                case 'S':
                                case 's':
                                    greekSB.Append(toGreekOther(greekLetter.stigma, c)); break;
                                case 'P':
                                case 'p':
                                    greekSB.Append(toGreekOther(greekLetter.sho, c)); break;
                                case 'H':
                                case 'h':
                                    greekSB.Append(toGreekOther(greekLetter.heta, c)); break;
                                case 'K':
                                case 'k':
                                    greekSB.Append(toGreekOther(greekLetter.koppa, c)); break;
                                case 'T':
                                case 't':
                                    greekSB.Append(toGreekOther(greekLetter.sampi_archaic, c)); break;
                                case 'N':
                                case 'n':
                                    greekSB.Append(toGreekOther(greekLetter.pamphylian, c)); break;
                                default: greekSB.Append('`'); i--; break;
                            }
                            break;
                        }
                    default:
                        greekSB.Append(c); break;
                }
            }
            return greekSB.ToString();
        }
    }
}