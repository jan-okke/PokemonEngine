using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Nightshade : Move
	{
		public override string Name => "Night Shade";
		public override string Description => "The user makes the foe see a frightening mirage. It inflicts damage matching the user's level.";
		public override int BasePower => 1;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ghost;
		public Nightshade()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}