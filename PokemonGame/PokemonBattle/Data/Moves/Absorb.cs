using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Absorb : Move
	{
		public override string Name => "Absorb";
		public override string Description => "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.";
		public override int BasePower => 20;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IgnoresProtect => false;
		public Absorb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}