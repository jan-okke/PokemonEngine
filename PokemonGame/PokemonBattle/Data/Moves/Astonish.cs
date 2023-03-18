using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Astonish : Move
	{
		public override string Name => "Astonish";
		public override string Description => "The user attacks the target while shouting in a startling fashion. It may also make the target flinch.";
		public override int BasePower => 30;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Astonish()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}