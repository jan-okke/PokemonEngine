using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Irontail : Move
	{
		public override string Name => "Iron Tail";
		public override string Description => "The target is slammed with a steel-hard tail. It may also lower the target's Defense stat.";
		public override int BasePower => 100;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Irontail()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}