using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Willowisp : Move
	{
		public override string Name => "Will-O-Wisp";
		public override string Description => "The user shoots a sinister, bluish-white flame at the target to inflict a burn.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Willowisp()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}