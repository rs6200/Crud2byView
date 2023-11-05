using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStudy
{
   public class Bird
    {
        public string color;
        public string name;
        public string Wings;


        public void Pegion()
        {
            Console.WriteLine("I am Pegion");
            this.color = "red";
            this.name = "Peacock";

        }
       
       public void Swim() {

            Console.WriteLine("I can swim in ponds");      
        }


    }
    
   
        
    
}
