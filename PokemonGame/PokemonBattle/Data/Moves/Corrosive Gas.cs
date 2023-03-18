using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Corrosivegas : Move
	{
		public override string Name => "Corrosive Gas";
		public override string Description => "The user surrounds everything around it with highly acidic gas and melts away items they hold.";
		public override int BasePower => 0;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Poison;
		public Corrosivegas()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}