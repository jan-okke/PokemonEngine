using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Ironhead : Move
	{
		public override string Name => "Iron Head";
		public override string Description => "The foe slams the target with its steel-hard head. It may also make the target flinch.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Ironhead()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}