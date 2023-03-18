using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Speedswap : Move
	{
		public override string Name => "Speed Swap";
		public override string Description => "The user exchanges Speed stats with the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Speedswap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}