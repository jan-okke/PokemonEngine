using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Sacredfire : Move
	{
		public override string Name => "Sacred Fire";
		public override string Description => "The target is razed with a mystical fire of great intensity. It may also leave the target with a burn.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public override bool ThawsUser => true;
		public Sacredfire()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}