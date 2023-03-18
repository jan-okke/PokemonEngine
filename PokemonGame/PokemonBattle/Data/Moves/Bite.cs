using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bite : Move
	{
		public override string Name => "Bite";
		public override string Description => "The target is bitten with viciously sharp fangs. It may make the target flinch.";
		public override int BasePower => 60;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public Bite()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}