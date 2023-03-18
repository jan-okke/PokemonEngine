using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Heartswap : Move
	{
		public override string Name => "Heart Swap";
		public override string Description => "The user employs its psychic power to switch stat changes with the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Heartswap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}