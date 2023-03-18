using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Twister : Move
	{
		public override string Name => "Twister";
		public override string Description => "The user whips up a vicious tornado to tear at the opposing team. It may also make targets flinch.";
		public override int BasePower => 40;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IgnoresProtect => false;
		public Twister()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}