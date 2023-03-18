using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Endure : Move
	{
		public override string Name => "Endure";
		public override string Description => "The user endures any attack with at least 1 HP. Its chance of failing rises if it is used in succession.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 4;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Endure()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}