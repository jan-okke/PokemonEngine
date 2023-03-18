using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Belch : Move
	{
		public override string Name => "Belch";
		public override string Description => "The user lets out a damaging belch at the target. The user must eat a held Berry to use this move.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Poison;
		public override bool IgnoresProtect => false;
		public Belch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}