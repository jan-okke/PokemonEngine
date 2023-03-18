using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Suckerpunch : Move
	{
		public override string Name => "Sucker Punch";
		public override string Description => "This move enables the user to attack first. It fails if the target is not readying an attack, however.";
		public override int BasePower => 70;
		public override int PowerPoints => 5;
		public override int Priority => 1;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Suckerpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}