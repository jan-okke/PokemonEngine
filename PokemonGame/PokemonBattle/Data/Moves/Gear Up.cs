using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Gearup : Move
	{
		public override string Name => "Gear Up";
		public override string Description => "The user engages its gears to raise the Attack and Sp. Atk of allies with the Plus or Minus Ability.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Steel;
		public Gearup()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}