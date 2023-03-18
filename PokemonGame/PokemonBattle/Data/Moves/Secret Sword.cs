using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Secretsword : Move
	{
		public override string Name => "Secret Sword";
		public override string Description => "The user cuts with its long horn. The odd power contained in it does physical damage to the foe.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fighting;
		public Secretsword()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}