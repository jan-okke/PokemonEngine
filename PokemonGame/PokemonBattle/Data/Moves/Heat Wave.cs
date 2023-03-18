using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Heatwave : Move
	{
		public override string Name => "Heat Wave";
		public override string Description => "The user attacks by exhaling hot breath on the opposing team. It may also leave targets with a burn.";
		public override int BasePower => 95;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Heatwave()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}