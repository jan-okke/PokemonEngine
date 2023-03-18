using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Followme : Move
	{
		public override string Name => "Follow Me";
		public override string Description => "The user draws attention to itself, making all targets take aim only at the user.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 2;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Followme()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}