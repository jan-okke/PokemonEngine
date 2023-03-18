using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thunderwave : Move
	{
		public override string Name => "Thunder Wave";
		public override string Description => "A weak electric charge is launched at the target. It causes paralysis if it hits.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Electric;
		public Thunderwave()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}