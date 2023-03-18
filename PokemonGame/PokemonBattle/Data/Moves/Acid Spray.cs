using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Acidspray : Move
	{
		public override string Name => "Acid Spray";
		public override string Description => "The user spits fluid that works to melt the target. This harshly reduces the target's Sp. Def stat.";
		public override int BasePower => 40;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Poison;
		public override bool IgnoresProtect => false;
		public override bool IsBombMove => true;
		public Acidspray()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}