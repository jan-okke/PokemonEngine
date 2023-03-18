using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Scorchingsands : Move
	{
		public override string Name => "Scorching Sands";
		public override string Description => "The user throws scorching sand at the target to attack. This may also burn the target.";
		public override int BasePower => 70;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ground;
		public Scorchingsands()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}