using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Vinewhip : Move
	{
		public override string Name => "Vine Whip";
		public override string Description => "The target is struck with slender, whiplike vines to inflict damage.";
		public override int BasePower => 45;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Vinewhip()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}