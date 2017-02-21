using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "A String";
            double myDouble1 = 123.123546;
            double myDouble2 = 35.452;
            double myMoney = 1232345.123;
            myMoney = myMoney / 5;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Here we get to practice printing");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("The last two were practice putting new line characters");
            Console.WriteLine("Try to break this line up in two lines of code, ");
            Console.Write(" using the write method instead of writeline.");
            Console.WriteLine("   ");
            Console.WriteLine("Here you should be using a variable myString" + myString);
            Console.WriteLine("myDouble1: " + myDouble1);
            Console.WriteLine("myDouble2: " + myDouble2);
            Console.WriteLine("do that again with formating on the variable");
            Console.WriteLine("myDouble1: " + myDouble1);
            Console.WriteLine("myDouble2: " + myDouble2);
            Console.WriteLine("myMoney: " + myMoney);
            Console.WriteLine("let's do some inputs");
            Console.WriteLine("please enter something");
            string userInput = Console.ReadLine();
            Console.WriteLine("you entered:" + userInput);
            Console.WriteLine("Enter the value of pi to as many didgets as you know");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("sorry I zoned out, did you say: " + userInput2);
            string userInput3 = Console.ReadLine();
            Console.WriteLine("sorry zoned out again, can you enter it one more time?");
            string userInput4 = Console.ReadLine();
            Console.WriteLine("I think you said: 3.141592653589793238462643383279502884197169");
            Console.WriteLine("  ");
            Console.WriteLine("wow, you are smart");
        }
        }
    }