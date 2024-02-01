using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPractice.Dates
{
    public class DateProblems
    {
        //Write a C# Sharp program to extract the Date property and display the DateTime
        //value in the formatted output.
        public static void Display()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Complete Date :" + date);
            DateTime shortDate = date.Date;
            Console.WriteLine("ShortDate : " + shortDate.ToString("d"));
            Console.WriteLine("Display date using 24-hour clock format:  ");
            Console.WriteLine(date.ToString("g"));
            Console.WriteLine(shortDate.ToString("yyyy/MM/dd HH-mm"));
        }
        //Write a C# Sharp program to add whole and fractional values to a date and time.
        public static void Fractional()
        {
            double[] hr = {.08333, .16667, .25, .33333, .5, .66667, 1, 2,
                        29, 30, 31, 90, 365};
            DateTime dateValue = DateTime.Now;

            foreach (double time in hr)
                Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, time,
                                  dateValue.AddHours(time));
        }
        //**Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent.
        //This is done using the specifiedarray of formats, culture-specific format information, and style.
        public static void DateStyle()
        {

            string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                         "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                         "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                         "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                         "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};
            string[] dateStrings = {"8/1/2016 6:32 PM", "08/01/2016 6:32:05 PM",
                              "8/1/2016 6:32:00", "08/01/2016 06:32",
                              "08/01/2016 06:32:00 PM", "08/01/2016 06:32:00"};
            DateTime dateValue;

            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParseExact(dateString, formats,
                                           new CultureInfo("zh-CN"),
                                           DateTimeStyles.None,
                                           out dateValue))
                {
                    Console.WriteLine("Converted '{0}' to {1}.", dateString, dateValue);
                }
                else
                {
                    Console.WriteLine("Unable to convert '{0}' to a date.", dateString);
                }
            }

        }
        //** Write a C# Sharp program to convert the current DateTime object value to local time.
        public static void LocalTime()
        {
            DateTime localDateTime, univDateTime;

            Console.WriteLine("Enter a date and time.");
            string strDateTime = Console.ReadLine();

            try
            {
                localDateTime = DateTime.Parse(strDateTime);
                univDateTime = localDateTime.ToUniversalTime();

                Console.WriteLine("{0} local time is {1} universal time.",
                                       localDateTime,
                                        univDateTime);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
                return;
            }

            Console.WriteLine("Enter a date and time in universal time.");
            strDateTime = Console.ReadLine();

            try
            {
                univDateTime = DateTime.Parse(strDateTime);
                localDateTime = univDateTime.ToLocalTime();

                Console.WriteLine("{0} universal time is {1} local time.",
                                         univDateTime,
                                         localDateTime);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
                return;
            }

        }
        //Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent.
        public static void ConvertDateTime()
        {
            string[] dateStrings = {"05/01/2016 14:57:32.8", "2016-05-01 14:57:32.8",
                              "2016-05-01T14:57:32.8375298-04:00", "5/01/2015",
                              "5/01/2015 14:57:32.80 -07:00",
                              "1 May 2015 2:57:32.8 PM", "16-05-2016 1:00:32 PM",
                              "Fri, 15 May 2016 20:10:57 GMT" };
            DateTime dateValue;

            Console.WriteLine("Attempting to parse strings using {0} culture.",
                              CultureInfo.CurrentCulture.Name);
            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out dateValue))
                    Console.WriteLine("  Converted '{0}' to {1} ({2}).", dateString,
                                      dateValue, dateValue.Kind);
                else
                    Console.WriteLine("  Unable to parse '{0}'.", dateString);
            }
        }
    }
}
