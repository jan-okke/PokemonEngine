using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Playnice : Move
	{
		public override string Name => "Play Nice";
		public override string Description => "The user and target become friends. The target loses its will to fight, lowering its Attack stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Playnice()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}