using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Quickattack : Move
	{
		public override string Name => "Quick Attack";
		public override string Description => "The user lunges at the target at a speed that makes it almost invisible. It is sure to strike first.";
		public override int BasePower => 40;
		public override int PowerPoints => 30;
		public override int Priority => 1;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Quickattack()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}