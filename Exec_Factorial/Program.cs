using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//求1~10的階乘
			int result = 1;
			for (int i = 1; i <= 10; i++)
			{
				result *= i;
			}
			Console.WriteLine(result);
		}
	}
}
