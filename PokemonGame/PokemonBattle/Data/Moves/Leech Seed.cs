using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Leechseed : Move
	{
		public override string Name => "Leech Seed";
		public override string Description => "A seed is planted on the target. It steals some HP from the target every turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Leechseed()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}