using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Megadrain : Move
	{
		public override string Name => "Mega Drain";
		public override string Description => "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.";
		public override int BasePower => 40;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Grass;
		public Megadrain()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}