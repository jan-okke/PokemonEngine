using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Forestscurse : Move
	{
		public override string Name => "Forest's Curse";
		public override string Description => "The user puts a forest curse on the target. The target is now Grass type as well.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Forestscurse()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}