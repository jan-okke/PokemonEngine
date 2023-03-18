using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dizzypunch : Move
	{
		public override string Name => "Dizzy Punch";
		public override string Description => "The target is hit with rhythmically launched punches that may also leave it confused.";
		public override int BasePower => 70;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Dizzypunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}