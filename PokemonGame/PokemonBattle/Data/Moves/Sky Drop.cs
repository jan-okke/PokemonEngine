using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Skydrop : Move
	{
		public override string Name => "Sky Drop";
		public override string Description => "The user takes the foe into the sky, then drops it on the next turn. The foe cannot attack while airborne.";
		public override int BasePower => 60;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public Skydrop()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}