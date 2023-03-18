using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Boltbeak : Move
	{
		public override string Name => "Bolt Beak";
		public override string Description => "Stabs the target with an electrified beak. Power is doubled if the user attacks first.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Boltbeak()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}