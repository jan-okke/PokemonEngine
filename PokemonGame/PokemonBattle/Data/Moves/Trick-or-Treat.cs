using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Trickortreat : Move
	{
		public override string Name => "Trick-or-Treat";
		public override string Description => "The user takes the target trick-or-treating. This adds Ghost type to the target's type.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public Trickortreat()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}