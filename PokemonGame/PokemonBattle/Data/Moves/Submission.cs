using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Submission : Move
	{
		public override string Name => "Submission";
		public override string Description => "The user grabs the target and recklessly dives for the ground. It also hurts the user slightly.";
		public override int BasePower => 80;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Submission()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}