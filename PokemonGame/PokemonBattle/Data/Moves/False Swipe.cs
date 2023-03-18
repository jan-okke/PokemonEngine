using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Falseswipe : Move
	{
		public override string Name => "False Swipe";
		public override string Description => "A restrained attack that prevents the target from fainting. The target is left with at least 1 HP.";
		public override int BasePower => 40;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Falseswipe()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}