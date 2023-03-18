using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Honeclaws : Move
	{
		public override string Name => "Hone Claws";
		public override string Description => "The user sharpens its claws to boost its Attack stat and accuracy.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public Honeclaws()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}