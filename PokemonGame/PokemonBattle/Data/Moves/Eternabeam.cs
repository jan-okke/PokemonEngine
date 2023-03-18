using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Eternabeam : Move
	{
		public override string Name => "Eternabeam";
		public override string Description => "This is Eternatus's most powerful attack in its original form. The user can't move on the next turn.";
		public override int BasePower => 160;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Eternabeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}