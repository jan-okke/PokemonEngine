using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Sludgebomb : Move
	{
		public override string Name => "Sludge Bomb";
		public override string Description => "Unsanitary sludge is hurled at the target. It may also poison the target.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Poison;
		public Sludgebomb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}