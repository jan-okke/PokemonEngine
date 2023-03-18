using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psywave : Move
	{
		public override string Name => "Psywave";
		public override string Description => "The target is attacked with an odd psychic wave. The attack varies in intensity.";
		public override int BasePower => 1;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Psywave()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}