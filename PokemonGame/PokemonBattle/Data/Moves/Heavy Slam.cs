using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Heavyslam : Move
	{
		public override string Name => "Heavy Slam";
		public override string Description => "The user slams into the foe with its heavy body. The heavier the user, the greater the damage.";
		public override int BasePower => 1;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Heavyslam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}