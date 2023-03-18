using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Meteormash : Move
	{
		public override string Name => "Meteor Mash";
		public override string Description => "The target is hit with a hard punch fired like a meteor. It may also raise the user's Attack.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 20;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsPunchingMove => true;
		public Meteormash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}