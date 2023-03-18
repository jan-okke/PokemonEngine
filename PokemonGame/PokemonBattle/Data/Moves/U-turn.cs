using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Uturn : Move
	{
		public override string Name => "U-turn";
		public override string Description => "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public Uturn()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}