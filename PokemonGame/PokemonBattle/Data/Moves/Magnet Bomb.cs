using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Magnetbomb : Move
	{
		public override string Name => "Magnet Bomb";
		public override string Description => "The user launches steel bombs that stick to the target. This attack will not miss.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Magnetbomb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}