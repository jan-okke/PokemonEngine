using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Laserfocus : Move
	{
		public override string Name => "Laser Focus";
		public override string Description => "The user focuses intensely. The attack on the next turn always results in a critical hit.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Laserfocus()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}