using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Counter : Move
	{
		public override string Name => "Counter";
		public override string Description => "A retaliation move that counters any physical attack, inflicting double the damage taken.";
		public override int BasePower => 1;
		public override int PowerPoints => 20;
		public override int Priority => -5;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Counter()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}