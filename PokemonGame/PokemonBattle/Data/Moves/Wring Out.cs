using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Wringout : Move
	{
		public override string Name => "Wring Out";
		public override string Description => "The user powerfully wrings the foe. The more HP the foe has, the greater this attack's power.";
		public override int BasePower => 1;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Wringout()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}