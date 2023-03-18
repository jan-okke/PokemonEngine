using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dragondance : Move
	{
		public override string Name => "Dragon Dance";
		public override string Description => "The user vigorously performs a mystic, powerful dance that boosts its Attack and Speed stats.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IsDanceMove => true;
		public Dragondance()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}