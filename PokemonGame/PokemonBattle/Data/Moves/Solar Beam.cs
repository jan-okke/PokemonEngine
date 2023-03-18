using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Solarbeam : Move
	{
		public override string Name => "Solar Beam";
		public override string Description => "A two-turn attack. The user gathers light, then blasts a bundled beam on the second turn.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IgnoresProtect => false;
		public Solarbeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}