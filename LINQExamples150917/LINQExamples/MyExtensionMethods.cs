using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public static class MyExtensionMethods
    {
        /*
        Note that the first param of an extension method is the class you are
        extending. The this keyword is mandatory and differentiates
        extension methods from regular static functions. It tells the compiler
        the function CapitaliseFirstLetter should be added to the string type.
        In other words, CapitaliseFirstLetter method extends the functionality
        of the string sealed class.
        */
        public static string CapitaliseFirstLetter(this string str)
        {
            if(string.IsNullOrEmpty(str) == false)
            {
                char[] strArray = str.ToCharArray();
                strArray[0] = char.ToUpper(strArray[0]);
                string firstCharUpper = new string(strArray);
                return firstCharUpper;
            }
            else
            {
                return str;
            }
        }
    }

    public static class DateTimeExtensions
    {
        public static bool IsTargetDateBetweenStartAndEndDates(this DateTime targetDate,
                                                               DateTime startDate,
                                                               DateTime endDate)
        {
            return targetDate.Ticks >= startDate.Ticks && targetDate.Ticks <= endDate.Ticks;
        }
    }
}
