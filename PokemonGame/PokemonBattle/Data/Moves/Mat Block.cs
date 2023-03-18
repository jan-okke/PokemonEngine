using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Matblock : Move
	{
		public override string Name => "Mat Block";
		public override string Description => "Using a pulled-up mat as a shield, the user protects itself and its allies from damaging moves.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.UserSide;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fighting;
		public Matblock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}