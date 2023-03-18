using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Astralbarrage : Move
	{
		public override string Name => "Astral Barrage";
		public override string Description => "The user attacks by sending a frightful amount of small ghosts at opposing Pokémon.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Astralbarrage()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}