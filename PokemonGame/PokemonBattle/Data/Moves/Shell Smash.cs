using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Shellsmash : Move
	{
		public override string Name => "Shell Smash";
		public override string Description => "The user breaks its shell, lowering its defenses but sharply raising attacking and Speed stats.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Shellsmash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}