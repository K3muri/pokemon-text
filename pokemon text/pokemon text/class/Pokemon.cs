using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_text
{
    class Pokemon
    {
		public class pokemon : Pokemon
		{ }
        public class Bulbasaur : pokemon
		{
			public static string bulbasaur = "";
			int hp = 100;
			int atc = 5;
			int def = 5;
		}

        public class Squirtle : pokemon
		{
			public static string squirtle = "";
			int hp = 100;
			int atc = 5;
			int def = 10;
		}

        public class Charmander : pokemon
        {
			public static string charmander = "";
			int hp = 100;
			int atc = 10;
			int def = 5;
		}
    }
}
