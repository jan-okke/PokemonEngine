using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Powergem : Move
	{
		public override string Name => "Power Gem";
		public override string Description => "The user attacks with a ray of light that sparkles as if it were made of gemstones.";
		public override int BasePower => 80;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Rock;
		public Powergem()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}