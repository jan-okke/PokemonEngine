using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Camouflage : Move
	{
		public override string Name => "Camouflage";
		public override string Description => "The user's type is changed depending on its environment, such as at water's edge, in grass, or in a cave.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Camouflage()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}