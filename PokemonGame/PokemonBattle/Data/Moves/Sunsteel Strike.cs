using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Sunsteelstrike : Move
	{
		public override string Name => "Sunsteel Strike";
		public override string Description => "The user slams into the target with the force of a meteor. Can't be stopped by the target's Ability.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Sunsteelstrike()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}