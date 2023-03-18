using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mirrormove : Move
	{
		public override string Name => "Mirror Move";
		public override string Description => "The user counters the target by mimicking the target's last move.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Flying;
		public Mirrormove()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}