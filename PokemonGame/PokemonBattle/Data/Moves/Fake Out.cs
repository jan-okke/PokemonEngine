using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fakeout : Move
	{
		public override string Name => "Fake Out";
		public override string Description => "An attack that hits first and makes the target flinch. It only works the first turn the user is in battle.";
		public override int BasePower => 40;
		public override int PowerPoints => 10;
		public override int Priority => 3;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Fakeout()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}