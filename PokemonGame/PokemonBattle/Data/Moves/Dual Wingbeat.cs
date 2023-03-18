using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dualwingbeat : Move
	{
		public override string Name => "Dual Wingbeat";
		public override string Description => "The user slams the target with its wings. The target is hit twice in a row.";
		public override int BasePower => 40;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public Dualwingbeat()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}