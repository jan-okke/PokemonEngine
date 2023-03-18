using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Frenzyplant : Move
	{
		public override string Name => "Frenzy Plant";
		public override string Description => "The user slams the target with an enormous tree. The user can't move on the next turn.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Grass;
		public Frenzyplant()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}