using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fairylock : Move
	{
		public override string Name => "Fairy Lock";
		public override string Description => "By locking down the battlefield, the user keeps all Pokémon from fleeing during the next turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.BothSides;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fairy;
		public Fairylock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}