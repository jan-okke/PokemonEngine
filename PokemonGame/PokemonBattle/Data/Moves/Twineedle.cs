using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Twineedle : Move
	{
		public override string Name => "Twineedle";
		public override string Description => "The foe is stabbed twice by a pair of stingers. It may also poison the target.";
		public override int BasePower => 25;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IgnoresProtect => false;
		public Twineedle()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}