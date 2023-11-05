using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducatProject.Model
{
    internal class Seconf
    {
        public string Name = "Vishnu";

      public void Buy()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Enter Number");

            int a = int.Parse(Cosole.ReadLine());
            Console.WriteLine(a);

        }

    }
}
