using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudy
{
    internal  class Vechile
    {
        public string color;
        private  string name;
        // public int i = 10;
        public  Vechile()
        {
            i = 10;
        }
        public virtual int i { get; set; }
        public virtual string Name {

            get
            {
                return name;
            }


            set
            {
                name = value;
            }
        }
        public virtual void Start()
        {
            Console.WriteLine("vechile is Started");
            
        }
    }
}
