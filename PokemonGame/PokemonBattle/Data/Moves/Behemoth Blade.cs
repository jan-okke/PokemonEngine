using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Behemothblade : Move
	{
		public override string Name => "Behemoth Blade";
		public override string Description => "The user becomes a gigantic sword and cuts the target.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Behemothblade()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}