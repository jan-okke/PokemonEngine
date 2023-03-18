using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Calmmind : Move
	{
		public override string Name => "Calm Mind";
		public override string Description => "The user quietly focuses its mind and calms its spirit to raise its Sp. Atk and Sp. Def stats.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Calmmind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}