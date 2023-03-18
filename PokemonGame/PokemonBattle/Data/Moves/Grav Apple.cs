using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Gravapple : Move
	{
		public override string Name => "Grav Apple";
		public override string Description => "The user inflicts damage by dropping an apple from high above. This also lowers the target's Defense.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Gravapple()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}