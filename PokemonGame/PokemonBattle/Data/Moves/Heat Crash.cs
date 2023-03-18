using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Heatcrash : Move
	{
		public override string Name => "Heat Crash";
		public override string Description => "The user slams the foe with its flaming body. The heavier the user is, the greater the damage.";
		public override int BasePower => 1;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public Heatcrash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}