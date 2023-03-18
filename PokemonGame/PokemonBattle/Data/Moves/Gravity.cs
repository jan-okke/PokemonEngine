using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Gravity : Move
	{
		public override string Name => "Gravity";
		public override string Description => "Gravity is intensified for five turns, making moves involving flying unusable and negating Levitation.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Gravity()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}