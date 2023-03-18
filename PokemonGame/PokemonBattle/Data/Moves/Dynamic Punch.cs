using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dynamicpunch : Move
	{
		public override string Name => "Dynamic Punch";
		public override string Description => "The user punches the target with full, concentrated power. It confuses the target if it hits.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Dynamicpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}