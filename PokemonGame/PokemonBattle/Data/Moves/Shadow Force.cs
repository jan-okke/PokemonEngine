using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Shadowforce : Move
	{
		public override string Name => "Shadow Force";
		public override string Description => "The user disappears, then strikes the foe on the second turn. It hits even if the foe protects itself.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IsContactMove => true;
		public Shadowforce()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}