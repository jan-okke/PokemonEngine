using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Obstruct : Move
	{
		public override string Name => "Obstruct";
		public override string Description => "The user protects itself from all attacks. Direct contact lowers the attacker's Defense.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 4;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public Obstruct()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}