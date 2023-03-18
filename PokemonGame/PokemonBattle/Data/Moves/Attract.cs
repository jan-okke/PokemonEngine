using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Attract : Move
	{
		public override string Name => "Attract";
		public override string Description => "If it is the opposite gender of the user, the target becomes infatuated and less likely to attack.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Attract()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}