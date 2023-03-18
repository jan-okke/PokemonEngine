using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Waterpledge : Move
	{
		public override string Name => "Water Pledge";
		public override string Description => "A column of water strikes the target. When combined with its fire equivalent, it makes a rainbow.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public Waterpledge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}