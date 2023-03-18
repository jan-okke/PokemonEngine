using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aquaring : Move
	{
		public override string Name => "Aqua Ring";
		public override string Description => "The user envelops itself in a veil made of water. It regains some HP on every turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Water;
		public Aquaring()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}