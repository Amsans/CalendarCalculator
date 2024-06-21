using System;
using System.Text.RegularExpressions;

namespace CalendarCalculator
{
    class DateConverterService
    {
        public static readonly string DATE_PATTERN = "dd/MM/yyyy";
        public static readonly string TUT_FOUNDATION_DATE = "01/03/1996";
        public static readonly long CALENDAR_BASIS = 1110;
        public static readonly string TUT_FORMAT_REGEXP =
            "(M{0,4}(?:CM|CD|D?C{0,3})(?:XC|XL|L?X{0,3})(?:IX|IV|V?I{0,3}))" +
            "\\.((?:X{0,1})(?:IX|IV|V?I{0,3}))" +
            "\\.((?:X{0,1})(?:IX|IV|V?I{0,3}))" +
            "\\.((?:X{0,1})(?:IX|IV|V?I{0,3}))";

        public static readonly DateTime BASE_DATE = DateTime.ParseExact(TUT_FOUNDATION_DATE, DATE_PATTERN, System.Globalization.CultureInfo.InvariantCulture);

        public string ConvertToTUT(DateTime date)
        {
            double numberOfDays = (date - BASE_DATE).TotalDays + 1;
            double baseValue = numberOfDays + CALENDAR_BASIS;
            String convertedDate = ConvertToTUTFormat(baseValue.ToString());

            Console.Out.WriteLine(convertedDate);

            return convertedDate;
        }

        private string ConvertToTUTFormat(string days)
        {
            Regex regex = new Regex("(\\d+)(\\d)(\\d)(\\d)", RegexOptions.None);
            Match matcher = regex.Match(days);
            if (matcher != null)
            {
                int chiliadDigit = Int32.Parse(matcher.Groups[1].Value);
                int hecatontadeDigit = Int32.Parse(matcher.Groups[2].Value);
                int decadeDigit = Int32.Parse(matcher.Groups[3].Value);
                int dayOfDecadeDigit = Int32.Parse(matcher.Groups[4].Value);

                // Going backwards from the last digit to the first
                String dayOfDecade = RomanNumber.ToRoman(dayOfDecadeDigit);
                if (dayOfDecadeDigit == 0)
                {
                    decadeDigit -= 1;
                }
                String decade = RomanNumber.ToRoman(decadeDigit);
                if (decadeDigit <= 0)
                {
                    hecatontadeDigit -= 1;
                }
                String hecatontade = RomanNumber.ToRoman(hecatontadeDigit);
                if (hecatontadeDigit <= 0)
                {
                    chiliadDigit -= 1;
                }
                String chiliad = RomanNumber.ToRoman(chiliadDigit);

                return String.Format("{0}.{1}.{2}.{3}", chiliad, hecatontade, decade, dayOfDecade);
            }
            return "";
        }

        public string ConvertToCommon(string tutFormatString)
        {
            long days = GetNumberOfDays(tutFormatString);
            DateTime dateInCommonFormat = BASE_DATE.AddDays(days - 1);
            return dateInCommonFormat.ToString(DATE_PATTERN);
        }

        public long GetNumberOfDays(string tutFormatString)
        {
            long parsedDigits = ParseDigits(tutFormatString);
            long days =  parsedDigits - CALENDAR_BASIS;
            Console.Out.WriteLine("Days " + days);
            return days;
        }

        private static long ParseDigits(string tutFormatString)
        {
            Regex regex = new Regex(TUT_FORMAT_REGEXP, RegexOptions.None);
            Match matcher = regex.Match(tutFormatString);
            string digits = "";
            if (matcher != null)
            {

                string chiliadDigit = matcher.Groups[1].ToString();
                string hecatontadeDigit = matcher.Groups[2].ToString();
                string decadeDigit = matcher.Groups[3].ToString();
                string dayOfDecadeDigit = matcher.Groups[4].ToString();
                int chiliad = RomanNumber.ToArabic(chiliadDigit);
                int hecatontade = RomanNumber.ToArabic(hecatontadeDigit);
                int decade = RomanNumber.ToArabic(decadeDigit);
                int dayOfDecade = RomanNumber.ToArabic(dayOfDecadeDigit);
                if (dayOfDecade == 10)
                {
                    dayOfDecade = 0;
                    decade += 1;
                }
                if (decade >= 10)
                {
                    decade %= 10;
                    hecatontade += 1;
                }
                if (hecatontade >= 10)
                {
                    hecatontade %= 10;
                    chiliad += 1;
                }

                digits = String.Format("{0}{1}{2}{3}", chiliad, hecatontade, decade, dayOfDecade);
            }
            Console.Out.WriteLine("Parsed " + digits);
            return long.Parse(digits);
        }
    }
}
