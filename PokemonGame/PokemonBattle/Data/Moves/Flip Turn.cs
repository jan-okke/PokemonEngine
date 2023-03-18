using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Flipturn : Move
	{
		public override string Name => "Flip Turn";
		public override string Description => "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Water;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Flipturn()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}