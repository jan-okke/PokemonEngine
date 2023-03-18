using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Iceshard : Move
	{
		public override string Name => "Ice Shard";
		public override string Description => "The user flash freezes chunks of ice and hurls them at the target. This move always goes first.";
		public override int BasePower => 40;
		public override int PowerPoints => 30;
		public override int Priority => 1;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public Iceshard()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}