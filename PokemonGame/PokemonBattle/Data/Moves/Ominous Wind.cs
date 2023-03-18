using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Ominouswind : Move
	{
		public override string Name => "Ominous Wind";
		public override string Description => "The user blasts the target with a gust of repulsive wind. It may also raise all the user's stats at once.";
		public override int BasePower => 60;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ghost;
		public Ominouswind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}