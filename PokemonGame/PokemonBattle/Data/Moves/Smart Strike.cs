using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Smartstrike : Move
	{
		public override string Name => "Smart Strike";
		public override string Description => "The user stabs the target with a sharp horn. This attack never misses.";
		public override int BasePower => 70;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Smartstrike()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}