using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Pyroball : Move
	{
		public override string Name => "Pyro Ball";
		public override string Description => "Attacks by igniting a small stone and launching it as a fiery ball. May also burn the target.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public Pyroball()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}