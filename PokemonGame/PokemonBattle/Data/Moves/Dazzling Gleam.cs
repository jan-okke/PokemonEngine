using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dazzlinggleam : Move
	{
		public override string Name => "Dazzling Gleam";
		public override string Description => "The user damages opposing Pokémon by emitting a powerful flash.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fairy;
		public Dazzlinggleam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}