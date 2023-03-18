using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Shadowpunch : Move
	{
		public override string Name => "Shadow Punch";
		public override string Description => "The user throws a punch from the shadows. The punch lands without fail.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsPunchingMove => true;
		public Shadowpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}