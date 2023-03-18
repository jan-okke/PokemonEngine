using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fly : Move
	{
		public override string Name => "Fly";
		public override string Description => "The user soars, then strikes on the second turn. It can also be used for flying to any familiar town.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public Fly()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}