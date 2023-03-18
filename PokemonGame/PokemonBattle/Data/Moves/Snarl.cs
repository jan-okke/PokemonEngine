using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Snarl : Move
	{
		public override string Name => "Snarl";
		public override string Description => "The user yells as if it is ranting about something, making the target's Sp. Atk stat decrease.";
		public override int BasePower => 55;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dark;
		public Snarl()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}