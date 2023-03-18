using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bodyslam : Move
	{
		public override string Name => "Body Slam";
		public override string Description => "The user drops onto the target with its full body weight. It may leave the target with paralysis.";
		public override int BasePower => 85;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool HasExtraDamageOnMinimize => true;
		public Bodyslam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}