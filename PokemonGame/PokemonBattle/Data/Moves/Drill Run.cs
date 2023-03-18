using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Drillrun : Move
	{
		public override string Name => "Drill Run";
		public override string Description => "The user crashes into its target while rotating its body like a drill. Critical hits land more easily.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public Drillrun()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}