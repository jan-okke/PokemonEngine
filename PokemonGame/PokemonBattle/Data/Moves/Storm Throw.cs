using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Stormthrow : Move
	{
		public override string Name => "Storm Throw";
		public override string Description => "The user strikes the target with a fierce blow. This attack always results in a critical hit.";
		public override int BasePower => 60;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Stormthrow()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}