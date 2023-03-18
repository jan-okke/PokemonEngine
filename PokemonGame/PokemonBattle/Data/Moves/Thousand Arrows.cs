using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thousandarrows : Move
	{
		public override string Name => "Thousand Arrows";
		public override string Description => "This move also hits Pokémon that are in the air. Those Pokémon are knocked down to the ground.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public Thousandarrows()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}