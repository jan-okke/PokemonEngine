using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Detect : Move
	{
		public override string Name => "Detect";
		public override string Description => "It enables the user to evade all attacks. Its chance of failing rises if it is used in succession.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 4;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fighting;
		public Detect()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}