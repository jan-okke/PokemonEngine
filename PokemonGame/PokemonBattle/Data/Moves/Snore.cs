using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Snore : Move
	{
		public override string Name => "Snore";
		public override string Description => "An attack that can be used only if the user is asleep. The harsh noise may also make the target flinch.";
		public override int BasePower => 50;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 30;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public Snore()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}