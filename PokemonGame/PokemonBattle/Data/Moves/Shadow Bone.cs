using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Shadowbone : Move
	{
		public override string Name => "Shadow Bone";
		public override string Description => "The user beats the target with a bone containing a spirit. May lower the target's Defense stat.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public Shadowbone()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}