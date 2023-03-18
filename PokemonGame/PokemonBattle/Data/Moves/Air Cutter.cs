using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aircutter : Move
	{
		public override string Name => "Air Cutter";
		public override string Description => "The user launches razor-like wind to slash the opposing team. Critical hits land more easily.";
		public override int BasePower => 60;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Flying;
		public override bool IgnoresProtect => false;
		public override bool HasHighCriticalHitRate => true;
		public Aircutter()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}