using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Withdraw : Move
	{
		public override string Name => "Withdraw";
		public override string Description => "The user withdraws its body into its hard shell, raising its Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Water;
		public Withdraw()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}