using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Infestation : Move
	{
		public override string Name => "Infestation";
		public override string Description => "The target is infested and unable to flee for four to five turns.";
		public override int BasePower => 20;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Infestation()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}