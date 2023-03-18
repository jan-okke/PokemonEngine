using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Spiderweb : Move
	{
		public override string Name => "Spider Web";
		public override string Description => "The user ensnares the target with thin, gooey silk so it can't flee from battle.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Bug;
		public Spiderweb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}