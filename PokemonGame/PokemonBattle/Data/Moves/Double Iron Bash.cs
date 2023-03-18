using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Doubleironbash : Move
	{
		public override string Name => "Double Iron Bash";
		public override string Description => "The user rotates, centering the hex nut in its chest, and then strikes twice. May cause flinching.";
		public override int BasePower => 60;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Doubleironbash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}