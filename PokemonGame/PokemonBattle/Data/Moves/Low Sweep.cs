using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lowsweep : Move
	{
		public override string Name => "Low Sweep";
		public override string Description => "The user attacks the target's legs swiftly, reducing the target's Speed stat.";
		public override int BasePower => 65;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Lowsweep()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}