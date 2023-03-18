using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Raindance : Move
	{
		public override string Name => "Rain Dance";
		public override string Description => "The user summons a heavy rain that falls for five turns, powering up Water-type moves.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.BothSides;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Water;
		public Raindance()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}