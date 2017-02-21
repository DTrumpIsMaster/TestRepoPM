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
            int var1 = 9;
            double var2 = 4.7;
            string var3 = "74";
            string var4 = "U";
            double var5 = Convert.ToDouble(var1);
            var5 = var5 + var2;
            Console.WriteLine(var5);
            int myInt = Convert.ToInt32((int)var5);
            Console.WriteLine(myInt);
            var2 = var2 - 1;

        }
    }
}
