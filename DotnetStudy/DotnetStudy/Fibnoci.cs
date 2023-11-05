using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStudy
{
    public class Fibnoci
    {
        public void PrintFibnociSeries(int seriesLength)
        {

            int a = 0;
            int b = 1;
            int c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 1; i < seriesLength; i++)
            {


                Console.WriteLine(c);

                a = b;
                b = c;
                c = a + b;


            }
        }
        public void RecursiveFunctionExample(int i)
        {
            if (i < 10)
            {
                Console.WriteLine(i);
                RecursiveFunctionExample(++i);
            }
            else if(i >10)
            {
                Console.WriteLine("Enter Valid Number");
            }
           
        }

    }
}
