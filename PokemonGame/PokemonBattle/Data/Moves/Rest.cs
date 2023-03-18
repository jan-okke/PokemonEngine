using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rest : Move
	{
		public override string Name => "Rest";
		public override string Description => "The user goes to sleep for two turns. It fully restores the user's HP and heals any status problem.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Rest()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}