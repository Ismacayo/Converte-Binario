using System;

using System.Collections.Generic;
using System.Text;

namespace ConvertBinario
{
    public class Conversor
    {

        public static string ToNumBase(string num, int nBase, bool conSeparador, bool trimStart)
        {
            if (num == "") return "";

            StringBuilder s = new StringBuilder();
            ulong n = Convert.ToUInt64(num);
            if (n == 0 && conSeparador == false && trimStart == false)
            {
                return "0";
            }

            if (nBase < 2 || nBase > 36)
            {
                throw new ArgumentOutOfRangeException(
                  "A Base Deve ser no máximo 36 e mínimo 2");
            }

            int j = 0;
            double nu = n;

            while (nu > 0)
            {
                double k = (nu / nBase);
                nu = Math.Floor(k);
                int f = Convert.ToInt32((k - nu) * nBase);

                if (f > 9)// letras
                {
                    s.Append((char)(f + 55));
                }
                else // números
                {
                    s.Append((char)(f + 48));
                }
                if (conSeparador)
                {
                    j = j + 1;
                    if (j == 4)
                    {
                        j = 0;
                        s.Append(" ");
                    }
                }
            }

            char[] ac = s.ToString().ToCharArray();
            Array.Reverse(ac);
            s = new StringBuilder();
            foreach (char c in ac)
                s.Append(c);


            if (trimStart)
            {
                return s.ToString().TrimStart(" 0".ToCharArray()).TrimEnd();
            }
            else
            {
                return s.ToString().TrimEnd();
            }
        }


        public static string ToNumBase(string num, int nBase)
        {
            return ToNumBase(num, nBase, false, true);
        }
    
        public static string ToNumBase(string num, int nBase, bool trimStart)
        {
            return ToNumBase(num, nBase, false, trimStart);
        }

      
        public static string DecToBin(string num, bool conSeparador, bool trimStart)
        {
            return ToNumBase(num, 2, conSeparador, trimStart);
        }

       
        public static string DecToHex(string num, bool conSeparador, bool trimStart)
        {
            return ToNumBase(num, 16, conSeparador, trimStart);
        }

        public static string DecToOctal(string num, bool conSeparador, bool trimStart)
        {
            return ToNumBase(num, 8, conSeparador, trimStart);
        }


        public static ulong FromNumBase(string num, int nbase)
        {
            if(num == "") return 0;

            const int aMay = 'A' - 10;
            const int aMin = 'a' - 10;
            int i = 0;
            ulong n = 0;

            num = num.TrimStart("0".ToCharArray());

            for (int j = num.Length - 1; j >= 0; j--)
            {
                if (num[j] == '0')
                {
                    i += 1;
                }
                else if (num[j] == ' ')
                {
                    
                }
                else if (num[j] >= '1' && num[j] <= '9')
                {
                    int k = num[j] - 48;
                    if (k - nbase >= 0)
                        continue;
                    n = (ulong)(n + k * Math.Pow(nbase, i));
                    i += 1;
                }
                else if (num[j] >= 'A' && num[j] <= 'Z')
                {
                    int k = num[j] - aMay;
                    if (k - nbase >= 0)
                        continue;
                    n = (ulong)(n + k * Math.Pow(nbase, i));
                    i += 1;
                }
                else if (num[j] >= 'a' && num[j] <= 'z')
                {
                    int k = num[j] - aMin;
                    if (k - nbase >= 0)
                        continue;
                    n = (ulong)(n + k * Math.Pow(nbase, i));
                    i += 1;
                }
            }

            return n;
        }

        public static double FromHex(string num)
        {
            return FromNumBase(num, 16);
        }

        public static double FromOct(string num)
        {
            return FromNumBase(num, 8);
        }

        public static double FromBin(string num)
        {
            return FromNumBase(num, 2);
        }
    }
}