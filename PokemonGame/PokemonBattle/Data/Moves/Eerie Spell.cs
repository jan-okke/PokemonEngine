using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Eeriespell : Move
	{
		public override string Name => "Eerie Spell";
		public override string Description => "The user attacks with tremendous psychic power. This also removes 3 PP from the target's last move.";
		public override int BasePower => 80;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public Eeriespell()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}