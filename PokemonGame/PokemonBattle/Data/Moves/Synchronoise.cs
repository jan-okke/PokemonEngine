using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Synchronoise : Move
	{
		public override string Name => "Synchronoise";
		public override string Description => "Using an odd shock wave, the user damages any Pokémon of the same type as the user.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Synchronoise()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}