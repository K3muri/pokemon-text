using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	class Path3
	{
		public Path3()
		{
			p3();
		}

		public void p3()
		{
			Tools tools = new Tools();

			string part1 = $"narrator: {Variables.YourName} leavin your house once you are out side you look around \n " +
				           $"see tall grass a few buildings and Oak Pokemon Research Lab \n " +
							"input your choice? \n ";

			tools.TypeWriter(part1);
			tools.TypeWriter(Variables.YourName);

			while (true)
			{
				string path3 = (Console.ReadLine().ToLower());


				if (path3.Contains("grass"))
				{
					string choice1 = $"Oak : Hey! Wait! {Variables.YourName} Don't go out! \n" +
									$"It's unsafe! Wild POKEMON live in tall grass! You need your \n" +
									 $" own POKEMON for your protection. I know!Here, come with me! \n";

					string choice2 = $"narrator : oak takes {Variables.YourName} to his laboratory. ";

					tools.TypeWriter(choice1);
					tools.TypeWriter(choice2);
					tools.TypeWriter(Variables.YourName);

					Console.ReadLine();
					Console.Clear();
					Path4 a = new Path4();
				}

				else if (path3.Contains("Lab"))
				{
					string choice1 = $"Oak : Hey! {Variables.YourName} ";
									
					tools.TypeWriter(choice1);
					tools.TypeWriter(Variables.YourName);

					Console.ReadLine();
					Console.Clear();
					Path4 a = new Path4();
				}

				else if (path3.Contains("buildings"))
				{
					string choice2 = $"{Variables.YourName} : there no time for that i have to go see OAK \n" +
						$"input your choice \n ";

					tools.TypeWriter(Variables.YourName);
					tools.TypeWriter(choice2);

					Console.ReadLine();
				}

				else
				{
					Console.WriteLine("invalid input try again, input your new choice");
				}
			}
		}
	}
}
