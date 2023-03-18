using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Healorder : Move
	{
		public override string Name => "Heal Order";
		public override string Description => "The user calls out its underlings to heal it. The user regains up to half of its max HP.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Bug;
		public Healorder()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}