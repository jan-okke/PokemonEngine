using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Gravapple : Move
	{
		public override string Name => "Grav Apple";
		public override string Description => "The user inflicts damage by dropping an apple from high above. This also lowers the target's Defense.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Gravapple()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}