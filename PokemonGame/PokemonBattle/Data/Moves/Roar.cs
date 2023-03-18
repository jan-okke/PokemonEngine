using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Roar : Move
	{
		public override string Name => "Roar";
		public override string Description => "The target is scared off and replaced by another Pokémon in its party. In the wild, the battle ends.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => -6;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsSoundMove => true;
		public Roar()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}