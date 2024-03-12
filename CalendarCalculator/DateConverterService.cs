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
                int heliadaDigit = Int32.Parse(matcher.Groups[1].Value);
                int gekatontadaDigit = Int32.Parse(matcher.Groups[2].Value);
                int decadaDigit = Int32.Parse(matcher.Groups[3].Value);
                int dayOfDecadaDigit = Int32.Parse(matcher.Groups[4].Value);

                // Going backwards from the last digit to the first
                String dayOfDecada = RomanNumber.ToRoman(dayOfDecadaDigit);
                if (dayOfDecadaDigit == 0)
                {
                    decadaDigit -= 1;
                }
                String decada = RomanNumber.ToRoman(decadaDigit);
                if (decadaDigit <= 0)
                {
                    gekatontadaDigit -= 1;
                }
                String gekatontada = RomanNumber.ToRoman(gekatontadaDigit);
                if (gekatontadaDigit <= 0)
                {
                    heliadaDigit -= 1;
                }
                String heliada = RomanNumber.ToRoman(heliadaDigit);

                return String.Format("{0}.{1}.{2}.{3}", heliada, gekatontada, decada, dayOfDecada);
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

                string heliadaDigit = matcher.Groups[1].ToString();
                string gekatontadaDigit = matcher.Groups[2].ToString();
                string decadaDigit = matcher.Groups[3].ToString();
                string dayOfDecadaDigit = matcher.Groups[4].ToString();
                int heliada = RomanNumber.ToArabic(heliadaDigit);
                int gekatontada = RomanNumber.ToArabic(gekatontadaDigit);
                int decada = RomanNumber.ToArabic(decadaDigit);
                int dayOfDecada = RomanNumber.ToArabic(dayOfDecadaDigit);
                if (dayOfDecada == 10)
                {
                    dayOfDecada = 0;
                    decada += 1;
                }
                if (decada >= 10)
                {
                    decada %= 10;
                    gekatontada += 1;
                }
                if (gekatontada >= 10)
                {
                    gekatontada %= 10;
                    heliada += 1;
                }

                digits = String.Format("{0}{1}{2}{3}", heliada, gekatontada, decada, dayOfDecada);
            }
            Console.Out.WriteLine("Parsed " + digits);
            return long.Parse(digits);
        }
    }
}
