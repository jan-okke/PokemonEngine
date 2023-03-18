using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Behemothbash : Move
	{
		public override string Name => "Behemoth Bash";
		public override string Description => "The user becomes a gigantic shield and slams into the target.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Behemothbash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}