using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_For03
			//右側對齊星形三角形
			//做出一個共五排，由星星構成的直角三角形，且此直角位於右下方

			for (int i = 1; i <= 5; i++)
			{
				int countOfStar = i;
				int countOfSpace = 5 - i;
				string result = new string(' ', countOfSpace) + new string('*', countOfStar);
				Console.WriteLine(result);
			}
		}
	}
}
