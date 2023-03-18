using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Watershuriken : Move
	{
		public override string Name => "Water Shuriken";
		public override string Description => "The user hits the target with throwing stars 2-5 times in a row. This move always goes first.";
		public override int BasePower => 15;
		public override int PowerPoints => 20;
		public override int Priority => 1;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public Watershuriken()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}