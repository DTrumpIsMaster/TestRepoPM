using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1. Which of the following types of variables holds a whole numbers? (1pt)
               Answer 1. C

                2. Which of the following types of variables holds human readable text? (1pt)
               Answer 2. D
  
                3. Which of the following holds decimal numbers?(1pt)
               Answer 3. A

                4. Which of the following variables holds a 1 or a 0 (True/ False)?(1pt)
               Answer 4. B

                5. The single "=" is used for ___?(1pt)
               Answer 5. B

                6. What does the term allocating memory mean?(2pts)
               Answer 6. To store a value in a sperate location

                7. What is the difference between "initializing" and "declaring" a variable mean?(3pts)
               Answer 7. Initializing a variable is when you assign a value to a variable, an example being var1 = 5
               Answer 7. Declaring is when you first bring up a variable name, an example being int var1.

            //Fixing the error
            
                int myDecimal = 15.1;
                int myInteger = 10;
                string myString = "its Testing Time!";
                string myOtherString = "Yay Tests!";
                bool myBool = true;
                string myWord = Convert.ToDouble(myDecimal);
                myDecimal = Convert.ToString(myBool);
                int myOtherInt;
                myOtherInt = myInteger / 2; //initialize myOtherInt to half of myInteger
                myOtherInt = myOtherInt + 1; //add 1 to myOtherInt
                myInteger = myInteger + 5; //add five to myInteger
             */
            //create a program that does the below
            //declare and initialize a variable named myInt to the integer 4
            //declare and initialize a variable named myString to the string "Here Take This"
            //Print out the value of myInt and myString on 2 separate lines
            //add 4 to the value of myInt and put it back into myInt
            //multiply myInt by two and put the result into a new variable named anotherVar
            //divide anotherVar by 10 and put the result into a new variable aVar,
            //print the value of aVar, make sure that it is 1.6. (check variable types if it is 1)
            //cast(convert) myInt to a string and store it into a new variable named stringVar
            //using myString and stringVar and put the string "Here Take this88" it into stringVar 
            //print "stringVar holds: " along with the value of stringVar on one line.
            //ask the user to input a number and store the input as a number into var6 (can use two lines with temp string variable if you want)
            //add 15 to var6 
            //print var6 to the screen
            int myInt = 4;
            string myString = "Here Take This";
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            myInt = myInt + 4;
            int anotherVar = myInt * 2;
            double aVar = Convert.ToDouble(anotherVar) / 10;
            Console.WriteLine(aVar);
            string stringVar = Convert.ToString(myInt);
            Console.WriteLine(myString +stringVar +stringVar);
            string stringVarValue = "StringVar holds: ";
            Console.WriteLine(stringVarValue + stringVar);
            string anotherString1;
            anotherString1 = Console.ReadLine();
            int var6 = Convert.ToInt32(anotherString1);
            var6 = var6 + 15;
            Console.WriteLine(var6);
        }
    }
}
