using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Snaptrap : Move
	{
		public override string Name => "Snap Trap";
		public override string Description => "The user snares the target in a snap trap for four to five turns.";
		public override int BasePower => 35;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Snaptrap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}