using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type for numbers and I'll calculate the average");
            double userinput = Convert.ToDouble(Console.ReadLine());
       
            double userinput2 = Convert.ToDouble(Console.ReadLine());
           
            double userinput3 = Convert.ToDouble(Console.ReadLine());
          
            double userinput4 = Convert.ToDouble(Console.ReadLine());

            double Average = (userinput + userinput2 + userinput3 + userinput4) / 4;

            Console.WriteLine(Average);

        }
    }
}
