using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Scaleshot : Move
	{
		public override string Name => "Scale Shot";
		public override string Description => "Attacks by shooting scales two to five times in a row. Boosts the user's Speed but lowers its Defense.";
		public override int BasePower => 25;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IgnoresProtect => false;
		public Scaleshot()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}