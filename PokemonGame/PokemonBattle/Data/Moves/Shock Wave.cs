using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Shockwave : Move
	{
		public override string Name => "Shock Wave";
		public override string Description => "The user strikes the target with a quick jolt of electricity. This attack cannot be evaded.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public Shockwave()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}