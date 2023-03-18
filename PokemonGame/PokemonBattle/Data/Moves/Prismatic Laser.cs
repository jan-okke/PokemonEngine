using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Prismaticlaser : Move
	{
		public override string Name => "Prismatic Laser";
		public override string Description => "The user shoots powerful lasers using the power of a prism. The user can't move on the next turn.";
		public override int BasePower => 160;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Prismaticlaser()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}