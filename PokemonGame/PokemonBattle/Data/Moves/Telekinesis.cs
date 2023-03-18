using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Telekinesis : Move
	{
		public override string Name => "Telekinesis";
		public override string Description => "The user makes the target float with its psychic power. The target is easier to hit for three turns.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Telekinesis()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}