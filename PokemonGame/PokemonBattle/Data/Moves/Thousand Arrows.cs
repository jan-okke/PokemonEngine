using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thousandarrows : Move
	{
		public override string Name => "Thousand Arrows";
		public override string Description => "This move also hits Pokémon that are in the air. Those Pokémon are knocked down to the ground.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Thousandarrows()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}