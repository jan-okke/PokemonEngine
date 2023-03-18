using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Extrasensory : Move
	{
		public override string Name => "Extrasensory";
		public override string Description => "The user attacks with an odd, unseeable power. It may also make the target flinch.";
		public override int BasePower => 80;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Extrasensory()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}