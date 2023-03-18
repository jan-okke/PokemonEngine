using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Brutalswing : Move
	{
		public override string Name => "Brutal Swing";
		public override string Description => "The user swings its body around violently to inflict damage on everything in its vicinity.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearOthers;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Brutalswing()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}