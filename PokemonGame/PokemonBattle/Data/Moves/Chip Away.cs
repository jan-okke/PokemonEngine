using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Chipaway : Move
	{
		public override string Name => "Chip Away";
		public override string Description => "Seeking an opening, the user strikes continually. The foe's stat changes don't affect the damage.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Chipaway()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}