using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Steelwing : Move
	{
		public override string Name => "Steel Wing";
		public override string Description => "The target is hit with wings of steel. It may also raise the user's Defense stat.";
		public override int BasePower => 70;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Steelwing()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}