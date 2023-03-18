using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Teleport : Move
	{
		public override string Name => "Teleport";
		public override string Description => "The user switches place with a party Pokémon. Also warps to the last Pokémon Center visited.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => -6;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Teleport()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}