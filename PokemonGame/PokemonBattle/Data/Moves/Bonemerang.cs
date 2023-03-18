using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bonemerang : Move
	{
		public override string Name => "Bonemerang";
		public override string Description => "The user throws the bone it holds. The bone loops to hit the target twice, coming and going.";
		public override int BasePower => 50;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public Bonemerang()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}