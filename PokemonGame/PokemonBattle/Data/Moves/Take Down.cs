using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Takedown : Move
	{
		public override string Name => "Take Down";
		public override string Description => "A reckless, full-body charge attack for slamming into the foe. It also damages the user a little.";
		public override int BasePower => 90;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Takedown()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}