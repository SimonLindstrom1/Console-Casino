using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Utils
{
    public class Colours
    {
        private static readonly int[] redNumbers = {
        1, 3, 5, 7, 9, 12, 14, 16, 18,
        19, 21, 23, 25, 27, 30, 32, 34, 36
    };

        private static readonly int[] blackNumbers = {
        2, 4, 6, 8, 10, 11, 13, 15, 17,
        20, 22, 24, 26, 28, 29, 31, 33, 35
    };

        public static string GetColour(int number)
        {
            if (number == 0)
                return "grön";
            else if (redNumbers.Contains(number))
                return "röd";
            else if (blackNumbers.Contains(number))
                return "svart";
            else
                return "okänd";
        }
    }
}
