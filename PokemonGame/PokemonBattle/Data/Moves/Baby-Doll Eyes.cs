using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Babydolleyes : Move
	{
		public override string Name => "Baby-Doll Eyes";
		public override string Description => "The user stares with its baby-doll eyes, which lowers the target's Attack stat. Always goes first.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 1;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fairy;
		public Babydolleyes()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}