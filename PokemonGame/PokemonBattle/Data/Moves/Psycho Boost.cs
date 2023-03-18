using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psychoboost : Move
	{
		public override string Name => "Psycho Boost";
		public override string Description => "The user attacks the target at full power. The attack's recoil harshly reduces the user's Sp. Atk stat.";
		public override int BasePower => 140;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Psychoboost()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}