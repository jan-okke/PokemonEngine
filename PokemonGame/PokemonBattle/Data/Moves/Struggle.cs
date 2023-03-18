using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Struggle : Move
	{
		public override string Name => "Struggle";
		public override string Description => "An attack that is used in desperation only if the user has no PP. It also hurts the user slightly.";
		public override int BasePower => 50;
		public override int PowerPoints => 1;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Struggle()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}