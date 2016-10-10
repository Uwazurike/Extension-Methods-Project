using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_Methods_project
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Extension Methods Project v1");
            Console.WriteLine("\n");
            string mainString = "here i created a string ext to make the 2nd letter of this setence capitalized";
            mainString = mainString.CapitalizeSecondLetter();
            Console.WriteLine(mainString);
            Console.WriteLine("\n");
            int myValue = 9.Solve(5).Solve(4);
            Console.WriteLine(myValue);
            Console.WriteLine("\n");
            double myAddition = 0.9.Add(0.3).Add(0.4);
            Console.WriteLine(myAddition);
            Console.WriteLine("\n");
            char myChar = 'b';
            myChar = myChar.ChangeLetter();
            Console.WriteLine(myChar);
            Console.WriteLine("\n");
            float mySubtraction = 0.27F.Subtract(0.5F).Subtract(0.4F);
            Console.WriteLine(mySubtraction);
            Console.WriteLine("\n");
            bool hasSkills = false;
            hasSkills = hasSkills.CodingSkills();
            Console.WriteLine(hasSkills);

            int someNum = 3;
            Console.WriteLine(someNum.AddFive());

            someNum = 5;
            Console.WriteLine(someNum.AddFive());


            Console.ReadLine();
        }
    }

}

