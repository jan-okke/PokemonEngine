using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fairywind : Move
	{
		public override string Name => "Fairy Wind";
		public override string Description => "The user stirs up a fairy wind and strikes the target with it.";
		public override int BasePower => 40;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fairy;
		public Fairywind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}