using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	class Path2
	{
		public Path2()
		{
			p2();
		}
		public void p2()
		{
			Tools tools = new Tools();

			string part1 = "narrator: are you ready to \n" +
				" leave input answer? \n";

			tools.TypeWriter(part1);

			while (true)
			{
				string path2 = (Console.ReadLine().ToLower());


				if (path2.Contains("yes"))
				{
					string choice1 = "narrator: you leave your house and go outside to find PROF OAK";
					tools.TypeWriter(choice1);

					Console.ReadLine();
					Console.Clear();
					Path3 a = new Path3();
				}
				else if (path2.Contains("no"))
				{
					string choice2 = "narrator: you stay and talk to your mother then leave your house and go to find PROF OAK ";
					tools.TypeWriter(choice2);


					Console.ReadLine();
					Console.Clear();
					Path3 a = new Path3();
				}
				else
				{
					Console.WriteLine("invalid input try again, input your new choice");
				}
			}
		}
	}
}
