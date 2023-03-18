using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mindblown : Move
	{
		public override string Name => "Mind Blown";
		public override string Description => "The user attacks everything by causing its own head to explode. This also damages the user.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearOthers;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Mindblown()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}