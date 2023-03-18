using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thousandwaves : Move
	{
		public override string Name => "Thousand Waves";
		public override string Description => "The user attacks with a wave that crawls along the ground. Those it hits can't flee from battle.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public Thousandwaves()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}