using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Doublehit : Move
	{
		public override string Name => "Double Hit";
		public override string Description => "The user slams the target with a long tail, vines, or tentacle. The target is hit twice in a row.";
		public override int BasePower => 35;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Doublehit()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}