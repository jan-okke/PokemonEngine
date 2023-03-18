using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Firstimpression : Move
	{
		public override string Name => "First Impression";
		public override string Description => "Although this move has great power, it only works the first turn the user is in battle.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 2;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Firstimpression()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}