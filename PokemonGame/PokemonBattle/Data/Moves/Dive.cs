using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dive : Move
	{
		public override string Name => "Dive";
		public override string Description => "Diving on the first turn, the user rises and hits on the next turn. It can be used to dive in the ocean.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Water;
		public Dive()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}