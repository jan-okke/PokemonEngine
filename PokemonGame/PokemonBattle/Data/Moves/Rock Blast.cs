using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rockblast : Move
	{
		public override string Name => "Rock Blast";
		public override string Description => "The user hurls hard rocks at the target. Two to five rocks are launched in quick succession.";
		public override int BasePower => 25;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Rock;
		public Rockblast()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}