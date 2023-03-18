using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Zenheadbutt : Move
	{
		public override string Name => "Zen Headbutt";
		public override string Description => "The user focuses its willpower to its head and attacks the foe. It may also make the target flinch.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Psychic;
		public Zenheadbutt()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}