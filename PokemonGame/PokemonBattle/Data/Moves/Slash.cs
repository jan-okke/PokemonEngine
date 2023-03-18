using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Slash : Move
	{
		public override string Name => "Slash";
		public override string Description => "The target is attacked with a slash of claws or blades. Critical hits land more easily.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool HasHighCriticalHitRate => true;
		public Slash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}