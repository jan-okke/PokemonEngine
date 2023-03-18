using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Seedbomb : Move
	{
		public override string Name => "Seed Bomb";
		public override string Description => "The user slams a barrage of hard-shelled seeds down on the target from above.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Seedbomb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}