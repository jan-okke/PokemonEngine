using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Furyswipes : Move
	{
		public override string Name => "Fury Swipes";
		public override string Description => "The target is raked with sharp claws or scythes for two to five times in quick succession.";
		public override int BasePower => 18;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 80;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Furyswipes()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}