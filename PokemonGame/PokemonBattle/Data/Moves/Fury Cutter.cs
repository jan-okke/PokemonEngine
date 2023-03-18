using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Furycutter : Move
	{
		public override string Name => "Fury Cutter";
		public override string Description => "The target is slashed with scythes or claws. Its power increases if it hits in succession.";
		public override int BasePower => 40;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public Furycutter()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}