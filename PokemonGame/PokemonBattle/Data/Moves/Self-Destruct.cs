using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Selfdestruct : Move
	{
		public override string Name => "Self-Destruct";
		public override string Description => "The user blows up to inflict damage on all Pokémon in battle. The user faints upon using this move.";
		public override int BasePower => 200;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Selfdestruct()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}