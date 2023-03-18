using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Firepunch : Move
	{
		public override string Name => "Fire Punch";
		public override string Description => "The target is punched with a fiery fist. It may leave the target with a burn.";
		public override int BasePower => 75;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsPunchingMove => true;
		public Firepunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}