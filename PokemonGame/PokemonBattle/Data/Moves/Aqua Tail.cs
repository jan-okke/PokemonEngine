using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aquatail : Move
	{
		public override string Name => "Aqua Tail";
		public override string Description => "The user attacks by swinging its tail as if it were a vicious wave in a raging storm.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Water;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Aquatail()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}