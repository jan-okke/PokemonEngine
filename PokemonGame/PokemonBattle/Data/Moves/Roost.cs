using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Roost : Move
	{
		public override string Name => "Roost";
		public override string Description => "The user lands and rests its body. It restores the user's HP by up to half of its max HP.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Flying;
		public Roost()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}