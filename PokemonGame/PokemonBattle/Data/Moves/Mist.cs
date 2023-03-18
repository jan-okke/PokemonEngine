using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mist : Move
	{
		public override string Name => "Mist";
		public override string Description => "The user cloaks its body with a white mist that prevents any of its stats from being cut for five turns.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.UserSide;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ice;
		public Mist()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}