using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Cosmicpower : Move
	{
		public override string Name => "Cosmic Power";
		public override string Description => "The user absorbs a mystical power from space to raise its Defense and Sp. Def stats.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Cosmicpower()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}