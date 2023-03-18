using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Quiverdance : Move
	{
		public override string Name => "Quiver Dance";
		public override string Description => "The user performs a beautiful dance. It boosts the user's Sp. Atk, Sp. Def, and Speed stats.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IsDanceMove => true;
		public Quiverdance()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}