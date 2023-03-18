using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Waterspout : Move
	{
		public override string Name => "Water Spout";
		public override string Description => "The user spouts water to damage the foe. The lower the user's HP, the less powerful it becomes.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public Waterspout()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}