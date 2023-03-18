using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Frostbreath : Move
	{
		public override string Name => "Frost Breath";
		public override string Description => "The user blows a cold breath on the target. This attack always results in a critical hit.";
		public override int BasePower => 60;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ice;
		public Frostbreath()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}