using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Solarblade : Move
	{
		public override string Name => "Solar Blade";
		public override string Description => "The user gathers light energy into a blade, attacking the target on the next turn.";
		public override int BasePower => 125;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Solarblade()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}