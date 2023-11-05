using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
   public abstract class BankAccount
    {
        public abstract void Credit();
        public abstract void Add(int a, int b);
        public virtual void Debit()
        {
            Console.WriteLine("Account Debited");
        }

        
    }
    public interface InFace
    {
        public void Run()
        {
            Console.WriteLine("fgmsdgkms");
        }
        public void Call()
        {
            Console.WriteLine("fkgnadhgo");
        }
    }
    public class SavingAccount:BankAccount
    {
        public override void Credit()
        {
            Console.WriteLine("Account has been Credit");
        }
        public override void Add(int a, int b)
        {
            Console.WriteLine("a +b is : " + (a+b));
        }
        public override void Debit()
        {
            Console.WriteLine("Account Debit by Child");
        }

    }
}
