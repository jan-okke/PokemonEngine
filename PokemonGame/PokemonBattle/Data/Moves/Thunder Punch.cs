using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thunderpunch : Move
	{
		public override string Name => "Thunder Punch";
		public override string Description => "The target is punched with an electrified fist. It may also leave the target with paralysis.";
		public override int BasePower => 75;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public Thunderpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}