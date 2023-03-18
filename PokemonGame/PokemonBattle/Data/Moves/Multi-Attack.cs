using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Multiattack : Move
	{
		public override string Name => "Multi-Attack";
		public override string Description => "Cloaking itself in high energy, the user slams into the target. This move's type depends on the held memory.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Multiattack()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}