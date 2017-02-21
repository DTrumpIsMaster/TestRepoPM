using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Create_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 123.3245;
            int myInt = 12;
            float myFloat = (float) 19.6;
            myDouble = myInt + 0.6;
            myInt = Convert.ToInt32(myFloat);
            //rounded up
            myInt = Convert.ToInt32(myDouble);
            myDouble = myInt / 3;
            myDouble = 12.6;
            myFloat = (float) 13.8;
            myInt = Convert.ToInt32(myFloat) + Convert.ToInt32(myDouble);

          
        }
    }
}
