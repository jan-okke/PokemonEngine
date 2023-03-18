using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Metalclaw : Move
	{
		public override string Name => "Metal Claw";
		public override string Description => "The target is raked with steel claws. It may also raise the user's Attack stat.";
		public override int BasePower => 50;
		public override int PowerPoints => 35;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Metalclaw()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}