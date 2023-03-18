using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Technoblast : Move
	{
		public override string Name => "Techno Blast";
		public override string Description => "The user fires a beam of light at its target. The type changes depending on the Drive the user holds.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public Technoblast()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}