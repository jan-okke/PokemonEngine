using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Steameruption : Move
	{
		public override string Name => "Steam Eruption";
		public override string Description => "The user immerses the target in superheated steam. This may also leave the target with a burn.";
		public override int BasePower => 110;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 95;
		public override int EffectChance => 30;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public override bool ThawsUser => true;
		public override bool CanMetronome => false;
		public Steameruption()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}