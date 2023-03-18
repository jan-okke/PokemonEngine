using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dragonclaw : Move
	{
		public override string Name => "Dragon Claw";
		public override string Description => "The user slashes the target with huge, sharp claws.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dragon;
		public Dragonclaw()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}