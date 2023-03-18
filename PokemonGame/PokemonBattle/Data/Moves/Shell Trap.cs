using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Shelltrap : Move
	{
		public override string Name => "Shell Trap";
		public override string Description => "The user sets a shell trap. If it is hit by a physical move, the trap explodes and hurt the attacker.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => -3;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Shelltrap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}