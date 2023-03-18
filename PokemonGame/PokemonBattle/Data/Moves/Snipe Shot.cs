using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Snipeshot : Move
	{
		public override string Name => "Snipe Shot";
		public override string Description => "The user ignores any effects that redirect moves, allowing this move to hit the chosen target.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public Snipeshot()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}