using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
	public class Tools
	{
		public void TypeWriter(string Text)
		{
			for (int i = 0; i < Text.Length; i++)
			{
				Console.Write(Text[i]);
				System.Threading.
				Thread.Sleep(100);
			}
		}
	}
}
