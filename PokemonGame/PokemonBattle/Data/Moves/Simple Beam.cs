using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Simplebeam : Move
	{
		public override string Name => "Simple Beam";
		public override string Description => "The user's mysterious psychic wave changes the target's Ability to Simple.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Simplebeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}