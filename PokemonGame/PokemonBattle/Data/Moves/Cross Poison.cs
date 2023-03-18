using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Crosspoison : Move
	{
		public override string Name => "Cross Poison";
		public override string Description => "A slashing attack with a poisonous blade that may also poison the foe. Critical hits land more easily.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Poison;
		public Crosspoison()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}