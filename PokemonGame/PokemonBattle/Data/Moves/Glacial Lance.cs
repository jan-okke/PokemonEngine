using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Glaciallance : Move
	{
		public override string Name => "Glacial Lance";
		public override string Description => "The user attacks by hurling a blizzard-cloaked icicle lance at opposing Pokémon.";
		public override int BasePower => 130;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Glaciallance()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}