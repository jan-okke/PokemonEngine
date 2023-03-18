using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Soak : Move
	{
		public override string Name => "Soak";
		public override string Description => "The user shoots a torrent of water at the target and changes the target's type to Water.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Water;
		public Soak()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}