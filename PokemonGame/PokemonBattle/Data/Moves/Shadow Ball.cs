using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Shadowball : Move
	{
		public override string Name => "Shadow Ball";
		public override string Description => "The user hurls a shadowy blob at the target. It may also lower the target's Sp. Def stat.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public override bool IsBombMove => true;
		public Shadowball()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}