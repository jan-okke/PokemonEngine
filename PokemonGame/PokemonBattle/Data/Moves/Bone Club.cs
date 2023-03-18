using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Boneclub : Move
	{
		public override string Name => "Bone Club";
		public override string Description => "The user clubs the target with a bone. It may also make the target flinch.";
		public override int BasePower => 65;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 85;
		public override int EffectChance => 10;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public Boneclub()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}