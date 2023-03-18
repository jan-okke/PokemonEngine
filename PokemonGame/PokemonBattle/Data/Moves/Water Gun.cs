using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Watergun : Move
	{
		public override string Name => "Water Gun";
		public override string Description => "The target is blasted with a forceful shot of water.";
		public override int BasePower => 40;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public Watergun()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}