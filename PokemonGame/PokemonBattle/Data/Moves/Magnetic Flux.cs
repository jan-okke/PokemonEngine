using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Magneticflux : Move
	{
		public override string Name => "Magnetic Flux";
		public override string Description => "Manipulates magnetic fields to raise the Defense and Sp. Def stats of allies with Plus or Minus Abilities.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.UserAndAllies;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Electric;
		public Magneticflux()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}