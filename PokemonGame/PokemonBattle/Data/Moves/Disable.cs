using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Disable : Move
	{
		public override string Name => "Disable";
		public override string Description => "For four turns, this move prevents the target from using the move it last used.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Disable()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}