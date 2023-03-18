using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bodypress : Move
	{
		public override string Name => "Body Press";
		public override string Description => "The user attacks by slamming its body into the target. Power increases the higher the user's Defense is.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Bodypress()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}