using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypesConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //fix the errors in the conversions below then run in debug
            //mode and put the current values of the variable 
            //after the line is executed next to each line
            string myString = "1";//"1"
            char myChar = '2'; //'2'
            float myFloat = 10.7f;
            double myDouble = 10.9123457890;
            bool myBool = true;
            long myLong = 123123;
            int myInt = 12;
            myDouble = myFloat;//10.6999...
            myDouble = myInt;//12
            myDouble = myLong;//123123
            myDouble = Convert.ToDouble(myString);//1
            myDouble = myChar;//50
            myDouble = Convert.ToDouble(myBool);//1

            myString = "1";//"1"
            myChar = '2';//2
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myFloat = Convert.ToSingle(myDouble);//10.9123459
            myFloat = myInt;//12
            myFloat = myLong;//123123
            myFloat = Convert.ToSingle(myString);//1
            myFloat = myChar;//50
            myFloat = Convert.ToSingle(myBool);//1

            myString = "1";//"1"
            myChar = '2';
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            //for double/float to int does this round down or up?
            //rounds down
            //how could you make it round the other way?
            //I don't know
            myInt = Convert.ToInt32(myDouble);//11 
            myInt = Convert.ToInt32(myFloat);//11
            myInt = Convert.ToInt32(myLong);//123123
            myInt = Convert.ToInt32(myString);//1
            myInt = myChar;//50
            myInt = Convert.ToInt32(myBool);//1

            myString = "1";//"1"
            myChar = '2';
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

                       myLong = Convert.ToInt16(myDouble);//11
                       myLong = Convert.ToInt64(myFloat);//11
                       myLong = Convert.ToInt64(myInt);//12
                       myLong = Convert.ToInt64(myString);//1
                       myLong = myChar;//50
                       myLong = Convert.ToInt64(myBool);//true

                       myString = "1";//"1"
                       myChar = '2';
                       myFloat = 10.7f;
                       myDouble = 10.9123457890;
                       myBool = true;
                       myLong = 123123;
                       myInt = 12;
            
                       myString = Convert.ToString(myDouble);//10.912345789
                       myString = Convert.ToString(myFloat);//10.7
                       myString = Convert.ToString(myInt);//12
                       myString = Convert.ToString(myLong);//123123
                       myString = Convert.ToString(myChar);//2
                       myString = Convert.ToString(myBool);//true

                       myString = "1";//"1"
                       myChar = '2';
                       myFloat = 10.7f;
                       myDouble = 10.9123457890;
                       myBool = true;
                       myLong = 3;
                       myInt = 1;

            
                       myChar = Convert.ToChar(myInt);//1'\u0001
                       myChar = Convert.ToChar(myLong);//3'\u0003
                       myChar = Convert.ToChar(myString);//49'1

                       myString = "1";//"1"
                       myChar = '2';
                       myFloat = 1.7f;
                       myDouble = 0.9123457890;
                       myBool = true;
                       myLong = 0;
                       myInt = 1; 

                       myBool = Convert.ToBoolean(myDouble);//true
                       myBool = Convert.ToBoolean(myFloat);//true
                       myBool = Convert.ToBoolean(myInt);//true
                       myBool = Convert.ToBoolean(myLong);//false
        }
    }
}
