using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dragonascent : Move
	{
		public override string Name => "Dragon Ascent";
		public override string Description => "The user soars upward and drops at high speeds. Its Defense and Sp. Def stats are lowered.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public Dragonascent()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}