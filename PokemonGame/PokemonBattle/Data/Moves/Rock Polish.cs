using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rockpolish : Move
	{
		public override string Name => "Rock Polish";
		public override string Description => "The user polishes its body to reduce drag. It can sharply raise the Speed stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Rock;
		public Rockpolish()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}