using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bugbuzz : Move
	{
		public override string Name => "Bug Buzz";
		public override string Description => "The user vibrates its wings to generate a damaging sound wave. It may also lower the target's Sp. Def stat.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public Bugbuzz()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}