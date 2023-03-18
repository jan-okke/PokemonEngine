using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Freezeshock : Move
	{
		public override string Name => "Freeze Shock";
		public override string Description => "On the second turn, the user hits the foe with electrically charged ice. It may also paralyze the foe.";
		public override int BasePower => 140;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public Freezeshock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}