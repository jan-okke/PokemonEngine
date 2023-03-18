using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Growth : Move
	{
		public override string Name => "Growth";
		public override string Description => "The user's body grows all at once, raising the Atk and Sp. Atk stats.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Growth()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}