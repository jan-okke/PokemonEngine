using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Heartstamp : Move
	{
		public override string Name => "Heart Stamp";
		public override string Description => "The user unleashes a vicious blow after its cute act makes the foe less wary. It may also cause flinching.";
		public override int BasePower => 60;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 30;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Heartstamp()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}