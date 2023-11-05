using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudy
{
    internal class TwoWheeler:Vechile
    {
        //public int i = 20;
        public TwoWheeler()
        {
            i = 20;
        }
        public override int i {
            get;
            set;
        }
        public override  void Start()
        {
            Console.WriteLine("Two_Wheeler is Started:");
        }
        public  void Start(int x)
        {
            Console.WriteLine("TWo-Wheeler is started " + x);
        }
        private string name;
        public override string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
