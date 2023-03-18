using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mistball : Move
	{
		public override string Name => "Mist Ball";
		public override string Description => "A mistlike flurry of down envelops and damages the target. It may also lower the target's Sp. Atk.";
		public override int BasePower => 70;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 50;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public override bool IsBombMove => true;
		public Mistball()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}