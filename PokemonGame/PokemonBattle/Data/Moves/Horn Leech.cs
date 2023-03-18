using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Hornleech : Move
	{
		public override string Name => "Horn Leech";
		public override string Description => "The user drains the foe's energy with its horns. The user's HP is restored by half the damage inflicted.";
		public override int BasePower => 75;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Hornleech()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}