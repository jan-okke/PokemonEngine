using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Destinybond : Move
	{
		public override string Name => "Destiny Bond";
		public override string Description => "When this move is used, if the user faints, the foe that landed the knockout hit also faints.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ghost;
		public Destinybond()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}