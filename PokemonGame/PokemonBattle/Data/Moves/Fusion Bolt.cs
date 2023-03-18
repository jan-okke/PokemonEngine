using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fusionbolt : Move
	{
		public override string Name => "Fusion Bolt";
		public override string Description => "The user throws down a giant thunderbolt. It does more damage if influenced by an enormous flame.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public Fusionbolt()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}