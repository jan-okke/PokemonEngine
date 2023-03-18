using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Venoshock : Move
	{
		public override string Name => "Venoshock";
		public override string Description => "The user drenches the foe in a special poisonous liquid. Its power doubles if the target is poisoned.";
		public override int BasePower => 65;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Poison;
		public override bool IgnoresProtect => false;
		public Venoshock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}