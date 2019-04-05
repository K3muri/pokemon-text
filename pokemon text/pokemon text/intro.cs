using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	class intro
	{
		public intro()
		{
			start();
		}
		public void start()
		{
			Tools tools = new Tools();

			string part1 = ("Hello there! Welcome to the world of POKEMON! My name is OAK! People call me the POKEMON PROF! \n" +
							"First, what is your name ? \n input your name \n");
			
			string part2 = ($"Right!So your name is { Variables.YourName}");
			

			string part3 = ("This is my grandson. He's been your rival since you were young \n" +
							"humm...Erm, what is his name again? \n" +
							"input your Rival name \n");

			string part4 = ($"That's right! I remember now! His name is {Variables.RivalName}");

			string part5 = Variables.YourName + "Your very own POKEMON legend is about to unfold! \n" +
												"A world of dreams and adventures with POKEMON awaits!Let's go!";

			tools.TypeWriter(part1);

			Variables.YourName = (Console.ReadLine());

			tools.TypeWriter(part2);
			tools.TypeWriter(Variables.YourName);

			Console.ReadLine();
			Console.Clear();

			tools.TypeWriter(part3);
			Variables.RivalName = (Console.ReadLine());

			tools.TypeWriter(part4);
			tools.TypeWriter(Variables.RivalName);

			Console.ReadLine();
			Console.Clear();

			tools.TypeWriter(Variables.YourName);
			tools.TypeWriter(part5);
			
			Console.ReadLine();
			Console.Clear();

			Path0 next = new Path0();
		}
	}
}
