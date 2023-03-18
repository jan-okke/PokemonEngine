using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Hydrocannon : Move
	{
		public override string Name => "Hydro Cannon";
		public override string Description => "The target is hit with a watery blast. The user must rest on the next turn, however.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public Hydrocannon()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}