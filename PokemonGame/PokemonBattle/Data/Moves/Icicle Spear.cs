using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Iciclespear : Move
	{
		public override string Name => "Icicle Spear";
		public override string Description => "The user launches sharp icicles at the target. It strikes two to five times in a row.";
		public override int BasePower => 25;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public override bool IgnoresProtect => false;
		public Iciclespear()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}