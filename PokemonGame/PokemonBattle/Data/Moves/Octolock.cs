using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Octolock : Move
	{
		public override string Name => "Octolock";
		public override string Description => "Locks the target in and prevents it from fleeing. Also lowers the target's Defense and Sp. Def each turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fighting;
		public Octolock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}