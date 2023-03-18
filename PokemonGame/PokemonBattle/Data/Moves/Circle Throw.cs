using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Circlethrow : Move
	{
		public override string Name => "Circle Throw";
		public override string Description => "The user throws the target and drags out another Pokémon in its party. In the wild, the battle ends.";
		public override int BasePower => 60;
		public override int PowerPoints => 10;
		public override int Priority => -6;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Circlethrow()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}