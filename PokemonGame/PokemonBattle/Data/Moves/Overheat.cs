using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Overheat : Move
	{
		public override string Name => "Overheat";
		public override string Description => "The user attacks the target at full power. The attack's recoil sharply reduces the user's Sp. Atk stat.";
		public override int BasePower => 130;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Overheat()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}