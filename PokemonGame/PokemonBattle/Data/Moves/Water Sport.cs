using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Watersport : Move
	{
		public override string Name => "Water Sport";
		public override string Description => "The user soaks itself with water. The move weakens Fire-type moves while the user is in the battle.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.BothSides;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Water;
		public Watersport()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}