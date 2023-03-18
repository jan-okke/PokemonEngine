using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mudshot : Move
	{
		public override string Name => "Mud Shot";
		public override string Description => "The user attacks by hurling a blob of mud at the target. It also reduces the target's Speed.";
		public override int BasePower => 55;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ground;
		public Mudshot()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}