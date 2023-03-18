using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fellstinger : Move
	{
		public override string Name => "Fell Stinger";
		public override string Description => "When the user knocks out a target with this move, the user's Attack stat rises drastically.";
		public override int BasePower => 50;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public Fellstinger()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}