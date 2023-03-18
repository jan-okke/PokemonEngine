using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lastresort : Move
	{
		public override string Name => "Last Resort";
		public override string Description => "This move can be used only after the user has used all the other moves it knows in the battle.";
		public override int BasePower => 140;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Lastresort()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}