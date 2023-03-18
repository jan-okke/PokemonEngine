using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Zingzap : Move
	{
		public override string Name => "Zing Zap";
		public override string Description => "A strong electric blast crashes down on the target. This may also make the target flinch.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Zingzap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}