using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Geomancy : Move
	{
		public override string Name => "Geomancy";
		public override string Description => "The user absorbs energy and sharply raises its Sp. Atk, Sp. Def, and Speed stats on the next turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fairy;
		public Geomancy()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}