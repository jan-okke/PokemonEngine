using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Spark : Move
	{
		public override string Name => "Spark";
		public override string Description => "The user throws an electrically charged tackle at the target. It may also leave the target with paralysis.";
		public override int BasePower => 65;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public Spark()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}