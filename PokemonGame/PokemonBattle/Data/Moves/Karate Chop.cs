using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Karatechop : Move
	{
		public override string Name => "Karate Chop";
		public override string Description => "The target is attacked with a sharp chop. Critical hits land more easily.";
		public override int BasePower => 50;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool HasHighCriticalHitRate => true;
		public Karatechop()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}