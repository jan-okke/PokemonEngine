using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Synthesis : Move
	{
		public override string Name => "Synthesis";
		public override string Description => "The user restores its own HP. The amount of HP regained varies with the weather.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Synthesis()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}