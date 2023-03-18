using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Endeavor : Move
	{
		public override string Name => "Endeavor";
		public override string Description => "An attack move that cuts down the target's HP to equal the user's HP.";
		public override int BasePower => 1;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Endeavor()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}