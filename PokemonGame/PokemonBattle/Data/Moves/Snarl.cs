using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Snarl : Move
	{
		public override string Name => "Snarl";
		public override string Description => "The user yells as if it is ranting about something, making the target's Sp. Atk stat decrease.";
		public override int BasePower => 55;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 95;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public override bool CanMetronome => false;
		public Snarl()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}