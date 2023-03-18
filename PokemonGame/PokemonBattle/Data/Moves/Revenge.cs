using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Revenge : Move
	{
		public override string Name => "Revenge";
		public override string Description => "An attack move that inflicts double the damage if the user has been hurt by the foe in the same turn.";
		public override int BasePower => 60;
		public override int PowerPoints => 10;
		public override int Priority => -4;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Revenge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}