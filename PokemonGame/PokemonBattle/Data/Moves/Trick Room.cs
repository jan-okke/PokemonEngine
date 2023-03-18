using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Trickroom : Move
	{
		public override string Name => "Trick Room";
		public override string Description => "The user creates a bizarre area in which slower Pokémon get to move first for five turns.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => -7;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Trickroom()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}