using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pokemon_text
{
	class Program
	{
		static void Main(string[] args)
		{
			Tools tools = new Tools();

			string Start = "Welcome to my text based game on the classic pokemon games \n" +
				"here are the rules of the game \n" +
				"1) write in full sectences \n" +
				"2) if the cursor is not moving press 'enter' once \n" +
				"3) wait for 'input' to put your answer \n" +
				"Are you ready to start your adventure \n" +
					"input answer \n";

			tools.TypeWriter(Start);

			while (true)
			{
				string StartGame = (Console.ReadLine()).ToLower();

				if (StartGame.Contains("yes"))
				{
					Console.Clear();
					intro go = new intro();
				}

				else if (StartGame.Contains("no"))
				{
					Console.WriteLine("There will be no  adventure today ,good bye");
					Console.ReadKey();
					System.Environment.Exit(0);
				}

				else
				{
					Console.WriteLine("invalid input try again, input your new choice");
				}
			}


			//Path2 a = new Path2();
			//intro a = new intro();
		}
	}
}
