using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bugbite : Move
	{
		public override string Name => "Bug Bite";
		public override string Description => "The user bites the target. If the target is holding a Berry, the user eats it and gains its effect.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Bugbite()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}