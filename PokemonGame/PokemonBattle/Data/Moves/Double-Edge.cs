using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Doubleedge : Move
	{
		public override string Name => "Double-Edge";
		public override string Description => "A reckless, life-risking tackle. It also damages the user by a fairly large amount, however.";
		public override int BasePower => 120;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Doubleedge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}