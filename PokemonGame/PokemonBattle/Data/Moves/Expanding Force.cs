using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Expandingforce : Move
	{
		public override string Name => "Expanding Force";
		public override string Description => "The user attacks the target with psychic power. Powers up and hits all foes on Psychic Terrain.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Expandingforce()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}