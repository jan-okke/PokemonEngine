using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Flyingpress : Move
	{
		public override string Name => "Flying Press";
		public override string Description => "The user dives down onto the target from the sky. This move is Fighting and Flying type simultaneously.";
		public override int BasePower => 100;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Flyingpress()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}