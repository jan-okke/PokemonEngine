using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Payback : Move
	{
		public override string Name => "Payback";
		public override string Description => "If the user moves after the target, this attack's power will be doubled.";
		public override int BasePower => 50;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public Payback()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}