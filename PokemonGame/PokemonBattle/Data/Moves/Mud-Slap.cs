using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mudslap : Move
	{
		public override string Name => "Mud-Slap";
		public override string Description => "The user hurls mud in the target's face to inflict damage and lower its accuracy.";
		public override int BasePower => 20;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ground;
		public Mudslap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}