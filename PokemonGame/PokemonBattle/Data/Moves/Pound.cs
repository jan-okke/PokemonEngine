using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Pound : Move
	{
		public override string Name => "Pound";
		public override string Description => "The target is physically pounded with a long tail or a foreleg, etc.";
		public override int BasePower => 40;
		public override int PowerPoints => 35;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Pound()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}