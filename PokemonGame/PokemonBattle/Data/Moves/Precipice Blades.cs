using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Precipiceblades : Move
	{
		public override string Name => "Precipice Blades";
		public override string Description => "The user attacks its foes by manifesting the power of the land in fearsome blades of stone.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 85;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Precipiceblades()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}