using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "There once was a person named ";
            string s2 = " who lived in ";
            string s3 = "\nand who loved ";
            string s4 = ". At the age of ";
            string s5 = ", ";
            string s6 = " graduated \nfrom high school and went to work in a ";
            string s7 = " factory.\n";
            string s8 = " got married and had ";
            string s9 = " children and a pet ";
            string s10 = " named ";
            string s11 = ".\nEvery weekend the family and ";
            string s12 = " had fun ";
            string s13 = " together.";
          
            
            Console.WriteLine("(Name)");
            string name = Console.ReadLine();
            
            Console.WriteLine("(City)");
            string city = Console.ReadLine();
           
            Console.WriteLine("(Favorite Activity)");
            string activity = Console.ReadLine();

            Console.WriteLine("(Favorite Animal)");
            string animal = Console.ReadLine();
            
            Console.WriteLine("(Food or product)");
            string product = Console.ReadLine();

            Console.WriteLine("(Adjective and Noun)");
            string adjNoun = Console.ReadLine();

            Console.WriteLine("(Number Between 10-50)");
            string num1= Console.ReadLine();
            Convert.ToInt32(num1);

            Console.WriteLine("(Number Between 00-15)");
            string num2 = Console.ReadLine();
            Convert.ToInt32(num2);

            Console.WriteLine(" ");

            Console.Write(s1);
            Console.Write(name);
            Console.Write(s2);
            Console.Write(city);
            Console.Write(s3);
            Console.Write(activity);
            Console.Write(s4);
            Console.Write(num1);
            Console.Write(s5);
            Console.Write(name);
            Console.Write(s6);
            Console.Write(product);
            Console.Write(s7);
            Console.Write(name);
            Console.Write(s8);
            Console.Write(num2);
            Console.Write(s9);
            Console.Write(animal);
            Console.Write(s10);
            Console.Write(adjNoun);
            Console.Write(s11);
            Console.Write(adjNoun);
            Console.Write(s12);
            Console.Write(activity);
            Console.Write(s13);
            Console.WriteLine();
            //print out " Enter the following information and I will tell you a story
            //ask the user for their name and put the response in a string variable called 'name'
            //ask the user for a name of a city and put the response in a string variable called 'city'
            //ask the user for a physical activity (ex jogging, playing baseball) and put the response into a string variable called 'activity
            //ask the user for an animal and put the response in a string variable called 'animal'
            //ask the user for a food or product that you can buy and put the response in a string variable called 'product'
            //-----------------ask the usser for adjective and noun (ex blue car) and put into a string variable called 'adjNoun'
            //ask the user for a number between 10 and 50 and put into an integer variable named 'num1'
            //-------------ask the user for a number between 0 and 15 and put into an integer variable named 'num2'
            //print a blank line
            //the rest you can print all on 1 line (use console.write() (you can combine lines if you would like)
            //the following all mean to print the values of the variables
            //print s1
            //print name
            //print s2
            //print city
            //print s3
            //print activity
            //print s4
            //print age
            //print s5
            //print name
            //print s6
            //print product
            //print s7
            //print name
            //print s8
            //print num2
            //print s9
            //print animal
            //print s10
            //print adjNoun
            //print s11
            //print adjNoun
            //print s12
            //print activity
            //print s13
            //print new line

        }
    }
}
