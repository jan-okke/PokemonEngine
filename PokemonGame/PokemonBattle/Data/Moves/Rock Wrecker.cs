using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rockwrecker : Move
	{
		public override string Name => "Rock Wrecker";
		public override string Description => "The user launches a huge boulder at the target to attack. It must rest on the next turn, however.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Rock;
		public override bool IgnoresProtect => false;
		public override bool IsBombMove => true;
		public Rockwrecker()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}