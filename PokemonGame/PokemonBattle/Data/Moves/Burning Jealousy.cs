using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Burningjealousy : Move
	{
		public override string Name => "Burning Jealousy";
		public override string Description => "The user attacks with energy from jealousy. This burns all foes that had their stats boosted this turn.";
		public override int BasePower => 70;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Burningjealousy()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}