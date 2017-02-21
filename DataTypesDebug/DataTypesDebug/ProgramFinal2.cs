using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            double var2 = 12.3;
            string var3 = "hello World";
            string var4 = "a string";
            string var5 = var4 + var3;
            double var6 = 3;
            var6 = var1/var6;  // value of var6 after this line should be 3.3333 not 3
            char var7 = 'k';
            bool var8 = (var2 == var6); //== is a comparison: read as is equal to
            bool var9 = true;
            double var10 = 10.7; //fix the righthand side
            bool var11 = true;
        }
    }
}
