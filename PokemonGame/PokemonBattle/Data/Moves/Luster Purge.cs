using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lusterpurge : Move
	{
		public override string Name => "Luster Purge";
		public override string Description => "The user lets loose a damaging burst of light. It may also reduce the target's Sp. Def stat.";
		public override int BasePower => 70;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Lusterpurge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}