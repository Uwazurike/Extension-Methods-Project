using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_Methods_project
{
    public static class Extend
    {
        public static string CapitalizeSecondLetter(this string mainString)
        {
            if (mainString.Length > 1)
            {
                char[] myArray = mainString.ToCharArray();
                myArray[1] = char.ToUpper(myArray[1]);
                return new string(myArray);
            }
            return mainString;
        }

        public static int AddFive(this int origNum)
        {
            return origNum + 5;
        }

        public static double Add(this double myDouble1, double myDouble2)
        {
                return myDouble1 + myDouble2;
        }
        public static char ChangeLetter(this char myChar)
        {
            if (myChar == 'b')
            {
                return ('X');
            }
            return myChar;
        }
        public static int Solve(this int myInt1, int myInt2)
        {
            {
                return myInt1 * myInt2;
            }
        }
        public static float Subtract(this float myFloat1, float myFloat2)
        {
            {
                return myFloat1-myFloat2;
            }
        }
    }
}
