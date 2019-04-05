using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	class Path5
	{
		public Path5()
		{
			p5();
		}

		public void p5()
		{
			Console.WriteLine("coming soon!!! thanks for playing ");

			Console.Write("press 1 to restart the program \n" +
						 "press 2 to exit the program \n" +
							"input selection--->");

			string path0 = (Console.ReadLine()).ToLower();
			if (path0.Contains("1"))
			{
				Console.WriteLine("you have select  to restart ");
				Console.Clear();
				intro go = new intro();
			}

			else
			{
				Console.WriteLine("you have select to exit the program ");
				Console.ReadLine();
				System.Environment.Exit(0);
			}
		}
	}
}
