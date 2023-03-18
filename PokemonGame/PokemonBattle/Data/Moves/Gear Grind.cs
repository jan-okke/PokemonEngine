using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Geargrind : Move
	{
		public override string Name => "Gear Grind";
		public override string Description => "The user attacks by throwing two steel gears at its target.";
		public override int BasePower => 50;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Geargrind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}