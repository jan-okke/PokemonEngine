using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Earthpower : Move
	{
		public override string Name => "Earth Power";
		public override string Description => "The user makes the ground under the foe erupt with power. It may also lower the target's Sp. Def.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ground;
		public Earthpower()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}