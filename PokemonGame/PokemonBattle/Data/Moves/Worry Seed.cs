using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Worryseed : Move
	{
		public override string Name => "Worry Seed";
		public override string Description => "A seed that causes worry is planted on the foe. It prevents sleep by making its Ability Insomnia.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Worryseed()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}