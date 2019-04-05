using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	class Path4
	{
		public Path4()
		{
			p4();
		}

		public void p4()
		{
			//System.Environment.Exit(0);

			Tools tools = new Tools();
			string part1 = $"narrator: PROF OAK takes {Variables.YourName} to his laboratory.They approach a table \n" +
							$" upon which three Poke Balls have been placed, and next to which {Variables.RivalName} is present.";

			string part2 =$"{Variables.RivalName}: Gramps!I'm fed up with waiting! \n" +
							$"PROF OAK : {Variables.RivalName} Let me think...Oh, that's right, I told you to come! Just wait!";

			string part3 = "When I was young, I was a serious POKEMON trainer.In my old age, I have only 3 left, \n" +
							$"Here, {Variables.YourName} There are 3 POKEMON here They are inside the POKE BALLS you can have one";

			string part4 = $"{Variables.RivalName}: Hey!Gramps!What about me? \n" +
							$"PROF OAK :  Be patient!! {Variables.RivalName} you can have one too!";

			string part5 = $"PROF OAK : {Variables.YourName} Choose";

			string part6 = "narrator: you approach a table upon which three Poke Balls \n " +
							"narrator: wich do you chose the one on the left? , right ? , or center? \n" +
							"input answer \n";

			tools.TypeWriter(part1);
			tools.TypeWriter(Variables.YourName);
			tools.TypeWriter(Variables.RivalName);
			Console.ReadKey();
			Console.Clear();

			tools.TypeWriter(part2);
			tools.TypeWriter(Variables.RivalName);
			Console.ReadKey();
			Console.Clear();

			tools.TypeWriter(part3);
			tools.TypeWriter(Variables.YourName);
			Console.ReadKey();
			Console.Clear();

			tools.TypeWriter(part4);
			tools.TypeWriter(Variables.RivalName);
			Console.ReadKey();
			Console.Clear();

			tools.TypeWriter(part5);
			tools.TypeWriter(Variables.YourName);
			Console.ReadKey();
			Console.Clear();

			tools.TypeWriter(part6);

			while (true)
			{
				string path4 = (Console.ReadLine().ToLower());

				if (path4.Contains("left"))
				{
					Console.WriteLine("narrator: you have chosein the left poke ball \n there was a Bulbasaur inside");
					Console.ReadKey();
					Console.WriteLine("input pokemon name ");
					Pokemon.Bulbasaur.bulbasaur = (Console.ReadLine());

					tools.TypeWriter(Pokemon.Bulbasaur.bulbasaur);

					Console.ReadKey();
					Console.WriteLine(Variables.RivalName + "got a  Charmander ");

					Console.Clear();
					Path5 next = new Path5();
				}

				else if (path4.Contains("right"))
				{
					Console.WriteLine("narrator: you have chosein the right poke ball \n there was a Squirtle inside");
					Console.ReadKey();
					Console.WriteLine("input pokemon name ");
					Pokemon.Squirtle.squirtle = (Console.ReadLine());

					tools.TypeWriter(Pokemon.Squirtle.squirtle);

					Console.ReadKey();
					Console.WriteLine(Variables.RivalName + "got a Bulbasaur");

					Console.Clear();
					Path5 next = new Path5();
				}

				else if (path4.Contains("center"))
				{
					Console.WriteLine("narrator: you have chosein the center poke ball \n there was a  Charmander inside");
					Console.ReadKey();
					Console.WriteLine("input pokemon name ");
					Pokemon.Charmander.charmander = Console.ReadLine();

					tools.TypeWriter(Pokemon.Charmander.charmander);

					Console.ReadKey();
					Console.WriteLine(Variables.RivalName + "got a Squirtle ");

					Console.Clear();
					Path5 next = new Path5();
				}
			}
		}
	}
}
