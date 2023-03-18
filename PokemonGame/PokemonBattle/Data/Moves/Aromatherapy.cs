using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aromatherapy : Move
	{
		public override string Name => "Aromatherapy";
		public override string Description => "The user releases a soothing scent that heals all status problems affecting the user's party.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.UserAndAllies;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Aromatherapy()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}