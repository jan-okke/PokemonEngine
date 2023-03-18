using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Tailglow : Move
	{
		public override string Name => "Tail Glow";
		public override string Description => "The user stares at flashing lights to focus its mind, drastically raising its Sp. Atk stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Bug;
		public Tailglow()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}