using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lunardance : Move
	{
		public override string Name => "Lunar Dance";
		public override string Description => "The user faints. In return, the Pokémon taking its place will have its status and HP fully restored.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IsDanceMove => true;
		public Lunardance()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}