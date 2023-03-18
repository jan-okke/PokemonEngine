using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Wingattack : Move
	{
		public override string Name => "Wing Attack";
		public override string Description => "The target is struck with large, imposing wings spread wide to inflict damage.";
		public override int BasePower => 60;
		public override int PowerPoints => 35;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Wingattack()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}