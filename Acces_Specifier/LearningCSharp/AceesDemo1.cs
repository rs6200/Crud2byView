using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
	public class AceesDemo1
	{
		private void Test1()
		{
			Console.WriteLine("Private Methode.");
		}

		internal void Test2()
		{
			Console.WriteLine("Internal Methode.");
		}
		protected void Test3()
		{
			Console.WriteLine("Protected Methode.");
		}
		protected internal void Test4()
		{
			Console.WriteLine("Protected Internal Methode.");
		}
		public void Test5()
		{
			Console.WriteLine("Public Methode.");
		}

		//static void Main(string[] args)
		//{

		//	AceesDemo1 c = new AceesDemo1();
		//	c.Test1();
		//	c.Test2();
		//	c.Test3();
		//	c.Test4();
		//	c.Test5();
		//}

	}

}
