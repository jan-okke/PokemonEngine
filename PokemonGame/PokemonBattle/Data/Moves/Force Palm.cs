using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Forcepalm : Move
	{
		public override string Name => "Force Palm";
		public override string Description => "The target is attacked with a shock wave. It may also leave the target with paralysis.";
		public override int BasePower => 60;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Forcepalm()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}