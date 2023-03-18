using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Powerswap : Move
	{
		public override string Name => "Power Swap";
		public override string Description => "The user employs its psychic power to switch changes to its Attack and Sp. Atk with the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Powerswap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}