using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thousandwaves : Move
	{
		public override string Name => "Thousand Waves";
		public override string Description => "The user attacks with a wave that crawls along the ground. Those it hits can't flee from battle.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Thousandwaves()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}