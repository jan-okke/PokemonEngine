using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Healingwish : Move
	{
		public override string Name => "Healing Wish";
		public override string Description => "The user faints. In return, the Pokémon taking its place will have its HP restored and status cured.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Healingwish()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}