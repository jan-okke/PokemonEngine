using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Poisonjab : Move
	{
		public override string Name => "Poison Jab";
		public override string Description => "The target is stabbed with a tentacle or arm seeped with poison. It may also poison the target.";
		public override int BasePower => 80;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Poison;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Poisonjab()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}