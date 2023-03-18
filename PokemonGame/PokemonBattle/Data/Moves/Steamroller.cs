using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Steamroller : Move
	{
		public override string Name => "Steamroller";
		public override string Description => "The user crushes its foes by rolling over them. This attack may make the target flinch.";
		public override int BasePower => 65;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public Steamroller()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}