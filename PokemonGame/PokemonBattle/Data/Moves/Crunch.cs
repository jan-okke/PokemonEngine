using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Crunch : Move
	{
		public override string Name => "Crunch";
		public override string Description => "The user crunches up the target with sharp fangs. It may also lower the target's Defense stat.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsBitingMove => true;
		public Crunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}