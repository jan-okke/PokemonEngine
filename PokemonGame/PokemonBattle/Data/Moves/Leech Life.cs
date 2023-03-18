using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Leechlife : Move
	{
		public override string Name => "Leech Life";
		public override string Description => "The user drains the target's blood. The user's HP is restored by half the damage taken by the target.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public Leechlife()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}