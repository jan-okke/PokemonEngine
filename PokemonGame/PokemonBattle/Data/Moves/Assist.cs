using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Assist : Move
	{
		public override string Name => "Assist";
		public override string Description => "The user hurriedly and randomly uses a move among those known by other Pokémon in the party.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Assist()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}