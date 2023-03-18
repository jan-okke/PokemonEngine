using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Iceball : Move
	{
		public override string Name => "Ice Ball";
		public override string Description => "The user continually rolls into the target over five turns. It becomes stronger each time it hits.";
		public override int BasePower => 30;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public Iceball()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}