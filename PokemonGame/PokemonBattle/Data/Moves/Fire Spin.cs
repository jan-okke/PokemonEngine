using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Firespin : Move
	{
		public override string Name => "Fire Spin";
		public override string Description => "The target becomes trapped within a fierce vortex of fire that rages for four to five turns.";
		public override int BasePower => 35;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 85;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Firespin()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}