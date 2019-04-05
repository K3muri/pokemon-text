using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	class Path1
	{
		public Path1()
		{
			p1();
		}
		public void p1()
		{
			Tools tools = new Tools();

			string part1 = $"narrator: you hear someone call out your name {Variables.YourName} you go to where you here your name \n " +
							$"narrator: you make your way down stars to see that it was your mother calling you again '{Variables.YourName}' ";

			string part2 = "narrator: she ask you \n" +
							"mother : are you ready, do you remeber what to day is \n " +
							 "input answer \n";

			tools.TypeWriter(Variables.YourName);
			tools.TypeWriter(part1);
			
			Console.ReadLine();

			tools.TypeWriter(part2);

			while (true)
			{
				string path1 = (Console.ReadLine().ToLower());

				if (path1.Contains("yes"))
				{
					string choice1 = "mother : Right.All boys leave home some day.It said so on TV. PROF.OAK, next door, is looking for you. ";
					tools.TypeWriter(choice1);

					Console.ReadLine();
					Console.Clear();
					Path2 a = new Path2();
				}

				else if (path1.Contains("no"))
				{
					string choice2 = "mother : how could you for geat today the big day \n" +
									" go see PROF.OAK, next door, he looking for you.";

					tools.TypeWriter(choice2);

					Console.ReadLine();
					Console.Clear();
					Path2 a = new Path2();
				}
				else
				{
					Console.WriteLine("invalid input try again, input your new choice");
				}
			}
		}
	}
}
