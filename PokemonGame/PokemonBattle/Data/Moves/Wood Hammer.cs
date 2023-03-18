using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Woodhammer : Move
	{
		public override string Name => "Wood Hammer";
		public override string Description => "The user slams its rugged body into the target to attack. The user also sustains serious damage.";
		public override int BasePower => 120;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Woodhammer()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}