using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Nuzzle : Move
	{
		public override string Name => "Nuzzle";
		public override string Description => "The user nuzzles its electrified cheeks against the target. This also leaves the target with paralysis.";
		public override int BasePower => 20;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public Nuzzle()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}