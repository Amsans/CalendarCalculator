using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarCalculator
{
    class RomanNumber
    {
        private static Dictionary<int, string> dict = new Dictionary<int, string>();

        static RomanNumber()
        {
            dict.Add(1000, "M");
            dict.Add(900, "CM");
            dict.Add(500, "D");
            dict.Add(400, "CD");
            dict.Add(100, "C");
            dict.Add(90, "XC");
            dict.Add(50, "L");
            dict.Add(40, "XL");
            dict.Add(10, "X");
            dict.Add(9, "IX");
            dict.Add(5, "V");
            dict.Add(4, "IV");
            dict.Add(1, "I");
        }

        public static string ToRoman(int number)
        {
            if (number == 0)
            {
                number = 10;
            }
            if (number == -1)
            {
                number = 9;
            }
            int l = dict.Where(x => x.Key <= number)
                        .OrderByDescending(x => x.Key)
                        .First().Key;
            if (number == l)
            {
                return dict[number];
            }
            return dict[l] + ToRoman(number - l);
        }

        public static int ToArabic(String number)
        {
            if (String.IsNullOrEmpty(number)) return 0;
            if (number.StartsWith("M")) return 1000 + ToArabic(number.Substring(1));
            if (number.StartsWith("CM")) return 900 + ToArabic(number.Substring(2));
            if (number.StartsWith("D")) return 500 + ToArabic(number.Substring(1));
            if (number.StartsWith("CD")) return 400 + ToArabic(number.Substring(2));
            if (number.StartsWith("C")) return 100 + ToArabic(number.Substring(1));
            if (number.StartsWith("XC")) return 90 + ToArabic(number.Substring(2));
            if (number.StartsWith("L")) return 50 + ToArabic(number.Substring(1));
            if (number.StartsWith("XL")) return 40 + ToArabic(number.Substring(2));
            if (number.StartsWith("X")) return 10 + ToArabic(number.Substring(1));
            if (number.StartsWith("IX")) return 9 + ToArabic(number.Substring(2));
            if (number.StartsWith("V")) return 5 + ToArabic(number.Substring(1));
            if (number.StartsWith("IV")) return 4 + ToArabic(number.Substring(2));
            if (number.StartsWith("I")) return 1 + ToArabic(number.Substring(1));
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}
