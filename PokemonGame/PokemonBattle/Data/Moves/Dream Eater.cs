using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dreameater : Move
	{
		public override string Name => "Dream Eater";
		public override string Description => "The user eats the dreams of a sleeping foe. It absorbs half the damage caused to heal the user's HP.";
		public override int BasePower => 100;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Dreameater()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}