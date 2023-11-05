using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStudy
{
    public class Inheritance
    {
        //public void Table(int a)
        //{

        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(a + "*" + i + "=" + a * i);

        //    }
        //}
       public string Color;



    }

    public class Car : Inheritance
    {

        public Car()
        {
            Console.WriteLine("print table");
        }
    }
    public class Odd_EvenCheck : Car
    {
        public void OddEven()
        {
            Console.WriteLine("Enter Number");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("This is Even Number");
            }
            else
            {
                Console.WriteLine("This is Odd Number");
            }

        }

        public void Largest(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is Largest Number");
                }
                else
                {
                    Console.WriteLine("c is Largest Number");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("B is lArgest Number");
                }
                else
                {
                    Console.WriteLine("c is largest number");
                }

            }

        }

        public void SwapNumber(int a, int b)
        {



            Console.WriteLine("without swap a =" + a);
            Console.WriteLine("without swap b =" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("swap a =" + a);
            Console.WriteLine("swap b =" + b);
        }


        public void Factorial()
        {
            int n = 5;
            int Factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                Factorial = Factorial * i;
            }
            Console.WriteLine(Factorial);

        }

        public void SumofNaturalNum(int n)
        {
            
            int SumofNaturalNum = 0;
            for(int i = 1; i <= n; i++)
            {
                SumofNaturalNum= SumofNaturalNum + i;
            }
            Console.WriteLine(SumofNaturalNum);
            
        }
    }
}
