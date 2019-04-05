using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	class Path0
	{
		public Path0()
		{
			p0();
		}

		public void p0()
		{
			Tools tools = new Tools();

			string part1 = "alarm clock noise *ringing* in background \n" +
				"" +
	"" +
 "" +
 "" +
 "" +
 "" +
							"narrator: You open your eyes and shut off the alarm clock";

			string part2 = "narrator: you sit up on your bed and look around your room \n" +
							"two things grab your attention a television and video games \n" +
							"narrator: what do you do input your choice \n ";


			tools.TypeWriter(part1);
			Console.ReadLine();
			
			tools.TypeWriter(part2);

			while (true)
			{
				string path0 = (Console.ReadLine()).ToLower();


				if (path0.Contains("bed"))
				{
					string choice1 = "narrator: you have gotten out of bed \n what do you now? \n" +
						"input your choice \n ";

					tools.TypeWriter(choice1);
				}

				else if (path0.Contains("sleep"))
				{
					string choice2 = $"narrator: {Variables.YourName} went back to sleep \n " +
									  $"his adventure has come to a end Good bye";

					tools.TypeWriter(choice2);
					tools.TypeWriter(Variables.YourName);

					Console.ReadLine();
					System.Environment.Exit(0);
				}

				else if (path0.Contains("get ready"))
				{
					string choice3 = "narrator: you take of your pajamas and put on your clothes for the day \n " +
						$" narrator: you hear someone call out your name '{Variables.YourName}' \n " +
							 $"you go to where you here your name '{Variables.YourName}' ";

					tools.TypeWriter(choice3);
					tools.TypeWriter(Variables.YourName);

					Console.ReadLine();
					Console.Clear();
					Path1 a = new Path1();
				}

				else if (path0.Contains("television") || path0.Contains("tv"))
				{
					string choice4 = " There's a movie on. Four boys are walking on railroad tracks. \n" +
						" I better go too. you cheang out your pajamas and put on your clothes for the day";

					tools.TypeWriter(choice4);

					Console.ReadLine();
					Console.Clear();
					Path1 a = new Path1();
				}

				else if (path0.Contains("video games"))
				{
					string choice5 = $"narrator: {Variables.YourName} is playing there favorite video game! ...Okay!It's time to go! \n " +
										"cheang out your pajamas and put on your clothes for the day ";


					tools.TypeWriter(choice5);
					tools.TypeWriter(Variables.YourName);

					Console.ReadLine();
					Console.Clear();
					Path1 a = new Path1();
				}

				else
				{
					Console.WriteLine("invalid input try again, input your new choice");
				}
			}
		}
	}
}
