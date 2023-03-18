using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Nightslash : Move
	{
		public override string Name => "Night Slash";
		public override string Description => "The user slashes the target the instant an opportunity arises. Critical hits land more easily.";
		public override int BasePower => 70;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public Nightslash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}